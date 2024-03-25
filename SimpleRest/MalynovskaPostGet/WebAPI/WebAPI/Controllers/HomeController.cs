using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        [HttpGet(Name = "GetHello")]
        public ActionResult<string> HelloWorld()
        {
            try
            {
                return Ok("Hello world!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [Route("header")]
        [HttpPost]
        public ActionResult<string> HelloHeader([FromHeader] string title, [FromHeader] string author, [FromHeader] int year)
        {
            try
            {
                Book book = new Book { Title = title, Author = author, Year = year };
                return Ok($"Hello {book}");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }

        [Route("body")]
        [HttpPost]
        public ActionResult<string> HelloBody([FromBody] Book book)
        {
            try
            {
                return Ok($"Hello {book}");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }

        [Route("params")]
        [HttpPost]
        public ActionResult<string> HelloParams([FromQuery] string title, [FromQuery] string author, [FromQuery] int year)
        {
            try
            {
                Book book = new Book { Title = title, Author = author, Year = year };
                return Ok($"Hello {book}");
            }
            catch (Exception ex)
            {
                return StatusCode(400, $"An error occurred: {ex.Message}");
            }
        }
    }
}
