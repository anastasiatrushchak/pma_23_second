using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Text;
using Newtonsoft.Json.Linq;

namespace WEBAPI.Controllers
{
    public class Body: ControllerBase
    { 
    
        [HttpPost]
        [Route("body")]
        public async Task<IActionResult> GetBody()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var requestBody = await reader.ReadToEndAsync();


                var requestBodyJson = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(requestBody);


                if (requestBodyJson.name != null)
                {
                    string name = requestBodyJson.name;
                    return Ok($"Hello, {name}!");
                }
                else
                {
                    return Ok("Enter the name attribute in the Body!");
                }
            }
        }

    }
}

