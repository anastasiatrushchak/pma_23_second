using Microsoft.AspNetCore.Mvc;
using UserApi.Models;
using UsersApi.Repositories;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private UserRepository _repository = new UserRepository();
        [HttpGet]
        public IActionResult GetUser([FromQuery] int Id)
        {
            try
            {
                User user = _repository.FindById(Id);
                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    Console.WriteLine(user.Data);
                    return Ok(user);
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
                List<User> users = _repository.GetAllUsers();  
                if (users == null)
                {
                    return NotFound();
                }
                else
                { 
                    return Ok(users);
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
                User user2 = _repository.Create(user);
                return Ok(user2);
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
                User user2 = _repository.Edit(user);
                return Ok(user2);
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }


        [HttpPatch] 
        public IActionResult UpdateUser([FromHeader] int Id, [FromHeader] string email)
        {
            try
            {
                User user = _repository.UpdateEmail(Id, email);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int Id)
        {
            try
            {
                User user = _repository.Delete(Id);
                return Ok(user);  
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }
    }
}

