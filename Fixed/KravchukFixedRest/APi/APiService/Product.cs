using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace APiService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult GetHelloWorld()
        {
            var message = new ResponseMessage { Message = "Hello World" };
            var json = JsonConvert.SerializeObject(message);
            return Content(json, "application/json");
        }

        [HttpPost("body")]
        public IActionResult PostBody([FromBody] JsonRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Name))
            {
                var error = new ResponseMessage { Message = "Empty request body or invalid data." };
                var json = JsonConvert.SerializeObject(error);
                return Content(json, "application/json");
            }

            var response = new ResponseMessage { Message = "Hello from JSON in body: " + request.Name };
            var jsonResponse = JsonConvert.SerializeObject(response);
            return Content(jsonResponse, "application/json");
        }

        [HttpPost("params")]
        public IActionResult PostParam([FromQuery] string name)
        {
            var response = new ResponseMessage { Message = "Hello from parameter: " + name };
            var jsonResponse = JsonConvert.SerializeObject(response);
            return Content(jsonResponse, "application/json");
        }

        [HttpPost("header")]
        public IActionResult PostHeader([FromHeader] string name)
        {
            var response = new ResponseMessage { Message = "Hello from header: " + name };
            var jsonResponse = JsonConvert.SerializeObject(response);
            return Content(jsonResponse, "application/json");
        }
    }

    public class JsonRequest
    {
        public string Name { get; set; }
    }
}
