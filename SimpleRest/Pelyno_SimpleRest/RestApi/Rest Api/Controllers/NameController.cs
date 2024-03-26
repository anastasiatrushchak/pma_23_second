using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("Name")]
    public class NameController : ControllerBase
    {
        private readonly string filePath = "D:\\C#\\Programming\\Rest Api\\data.json";

        public class Names
        {
            public string Name { get; set; }
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            return Ok("Hello world");
        }

        [HttpPost("Body")]
        public IActionResult Post_Body([FromBody] Names name)
        {
            if (name == null || string.IsNullOrEmpty(name.Name))
            {
                return BadRequest("Name is required.");
            }

            WriteNameToFile(name.Name);

            return Ok($"Hello {name.Name}");
        }

        [HttpPost("Params")]
        public IActionResult Post_Query([FromQuery] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Name is required.");
            }

            WriteNameToFile(name);

            return Ok($"Hello {name}");
        }

        [HttpPost("Header")]
        public IActionResult Post_Header([FromHeader] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Name is required.");
            }

            WriteNameToFile(name);

            return Ok($"Hello {name}");
        }

        private void WriteNameToFile(string name)
        {
            using (StreamWriter file = System.IO.File.AppendText(filePath))
            {
                string json = JsonConvert.SerializeObject(new { Name = name });
                file.WriteLine(json);
            }
        }
    }
}
