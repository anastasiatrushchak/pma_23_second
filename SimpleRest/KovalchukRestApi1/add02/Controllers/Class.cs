namespace add02.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET: api/Hello
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "hello world";
        }
    }
    
    [Route("api/[controller]")]
    [ApiController]
    public class Hello : ControllerBase
    {
        // POST: api/Hello
        [HttpPost]
        public ActionResult<string> Post([FromBody] string name, [FromHeader(Name = "headername")] string headerName = null)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return "Hello " + name;
            }
            else if (!string.IsNullOrEmpty(headerName))
            {
                return "Hello " + headerName;
            }
            else
            {
                return BadRequest("No valid data provided.");
            }
        }
    }


}


