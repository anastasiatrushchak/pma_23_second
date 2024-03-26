using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;
using System.Text;

public class MethodPostController : ControllerBase
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
