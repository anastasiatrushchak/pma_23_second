using Castle.Core.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class Api : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    User email = db.Users.FirstOrDefault(u => u.Email == user.Email);
                    if (email != null)
                    {
                        return BadRequest("This email already exists");
                    }

                    User phone_number = db.Users.FirstOrDefault(u => u.PhoneNumber == user.PhoneNumber);
                    if (phone_number != null)
                    {
                        return BadRequest("This phonenumber already exists");
                    }

                    db.Users.Add(user);
                    db.SaveChanges();
                }
                return Ok(user);
            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetUser([FromQuery] int? id)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    if (id==null)
                    {
                        var users = db.Users.Include(u => u.Car).ToList();
                        return Ok(users);
                    }
                    else
                    {
                        User user = db.Users.Include(u => u.Car).FirstOrDefault(u => u.Id == id);
                        if (user == null)
                            return NotFound();

                        return Ok(user);
                    }
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPut]
        public IActionResult EditUser(int id, [FromBody] User user)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var User = db.Users.Find(id);
                    if (User == null)
                    {
                        return NotFound($"User with ID {id} not found.");
                    }

                    User.Name = user.Name;
                    User.Email = user.Email;
                    User.PhoneNumber = user.PhoneNumber;
                    User.Car = user.Car;

                    db.Users.Update(User);
                    db.SaveChanges();
                    return Ok(User);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPatch]
        public IActionResult UpdateUser([FromHeader] int Id,/* [FromHeader] string email = null, [FromHeader] string name = null,*/ [FromHeader] string number = null)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    User user = db.Users.Include(u => u.Car).FirstOrDefault(u => u.Id == Id);
                    if (user == null)
                    {
                        return NotFound($"User with id {Id} not found.");
                    }
                    //if (email!=null)
                    //{
                    //    user.Email = email;
                    //}
                    //if (name != null)
                    //{
                    //    user.Name = name;
                    //}
                    if (number != null)
                    {
                        user.PhoneNumber = number;
                    }

                    db.Users.Update(user);
                    db.SaveChanges();
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }


        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                using (var db = new DBContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == id);

                    if (user == null)
                    {
                        return NotFound($"User with ID {id} not found.");
                    }

                    db.Users.Remove(user);
                    db.SaveChanges(); 

                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

