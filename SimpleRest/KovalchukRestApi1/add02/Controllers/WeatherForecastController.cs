using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanTest
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                    
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("hello world");
                });

                endpoints.MapPost("/", async context =>
                {
                    var name = context.Request.Query["name"];
                    var headers = JsonSerializer.Serialize(context.Request.Headers);

                    var responseMessage = $"My name is {name}";

                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync(responseMessage);
                });
            });
        }
    }
}
