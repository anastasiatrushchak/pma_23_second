using Microsoft.AspNetCore.Mvc;
using UserApi.Models;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUser([FromQuery]int Id)
        {
            try
            {
                using(ApplicationContext db = new ApplicationContext())
                {
                    User user = db.Users.Where(x => x.Id == Id).FirstOrDefault();
                    if (user == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        Console.WriteLine(user.Credentials);
                        return Ok(user);
                    }
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("all")] 
        public IActionResult GetUsers() 
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<User> users = db.Users.ToList();
                    if (users == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        foreach (var user in users)
                        {
                            Console.WriteLine(user.Credentials);
                        }
                        return Ok(users);
                    }
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut]
        public IActionResult EditUser([FromBody] User user)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.Users.Update(user);
                    db.SaveChanges();
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }

  
        [HttpPatch] //оновлюю щось у користувачі
        public IActionResult UpdateUser([FromHeader] int Id, [FromHeader] string email)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    User user = db.Users.Where(u => u.Id == Id).FirstOrDefault();
                    user.Email = email;
                    Console.WriteLine(user.Credentials);
                    db.Users.Update(user);
                    db.SaveChanges();
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser( int Id)
        {
            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    User user = db.Users.Where(u => u.Id == Id).FirstOrDefault();
                    Console.WriteLine(user.Credentials);
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }
    }
}
