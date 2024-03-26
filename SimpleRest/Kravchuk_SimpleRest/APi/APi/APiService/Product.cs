using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

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
        public string GetHelloWorld()
        {
            return "Hello World";
        }

        [HttpPost("body")]
        public string PostBody([FromBody] JsonRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Name))
            {
                return "Empty request body or invalid data.";
            }

            return "Hello from JSON in body: " + request.Name;
        }

        [HttpPost("llll")]
        public string PostParam([FromQuery] string name)
        {
            return "Hello from parameter: " + name;
        }

        [HttpPost("header")]
        public string PostHeader([FromHeader] string name)
        {
            return "Hello from header: " + name;
        }
    }

    public class JsonRequest
    {
        public string Name { get; set; }
    }
}