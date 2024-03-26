using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HomeController:ControllerBase
{
    [HttpGet("hello")]
    public string GetHello()
    {
        return "hello world";
    }

    [HttpPost("header")]
    public string PostHeader([FromHeader]string name)
    {
        return $"hello {name}";
    }
    
    [HttpPost("body")]
    public string PostBody([FromBody]Person person)
    {
        return $"hello {person.Firstname} {person.Lastname}";
    }
    
    [HttpPost("query")]
    public string PostQuery([FromQuery]string name)
    {
        return $"hello {name}";
    }
}