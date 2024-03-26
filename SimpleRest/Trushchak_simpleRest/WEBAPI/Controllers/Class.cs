using Microsoft.AspNetCore.Mvc;
namespace WEBAPI.Controllers

{
    [ApiController]
    [Route("get")]
    public class Class : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }
    }
}