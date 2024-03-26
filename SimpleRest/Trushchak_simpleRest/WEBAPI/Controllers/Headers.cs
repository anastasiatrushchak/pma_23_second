using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Text;
using Newtonsoft.Json.Linq;

namespace WEBAPI.Controllers
{
    public class Headers : ControllerBase
    {
        [HttpPost]
        [Route("headers")]
        public IActionResult GetHeaders()
        {
            if (Request.Headers.TryGetValue("Name", out StringValues name))
            {
                return Ok($"Hello, {name}!");
            }
            else
            {
                return Ok("Enter the name attribute in the Headers!");
            }
        }

    }
}



