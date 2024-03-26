using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostGet.Models;
using System.Xml.Linq;

namespace PostGet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, world!";
        }

        [HttpPost("headers")]
        public IActionResult PostHeaders([FromHeader] string name, [FromHeader] int age)
        {

            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                return Ok($"Name: {name}, Age: {age}");
            }
            catch(Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpPost("params")]
        public IActionResult PostParams(string name, int age)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }
                if (age <= 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                return Ok($"Name: {name}, Age: {age}");
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
            
        }

        [HttpPost("body")]
        public IActionResult PostBody([FromBody]Person person)
        {
            try
            {
                if (string.IsNullOrEmpty(person.Name))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }
                if (person.Age < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                return Ok($"Name: {person.Name}, Age: {person.Age}");
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }



}
