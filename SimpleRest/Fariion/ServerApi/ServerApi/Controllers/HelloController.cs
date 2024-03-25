
using Microsoft.AspNetCore.Mvc;
namespace ServerApi.Controllers

{
    [ApiController]
    [Route("get")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }
    }
}


