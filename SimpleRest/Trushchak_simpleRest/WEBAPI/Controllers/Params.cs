using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Text;

namespace WEBAPI.Controllers
{
    public class Params: ControllerBase
    {

        [HttpPost]
        [Route("params")]
        public IActionResult GetParams(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Ok("Enter the name attribute in the Params!");
            }
            else
            {
                return Ok($"Hello, {name}!");
            }
        }



    }
}

   