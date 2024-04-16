using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using userCrud.Models;
using Newtonsoft.Json;

namespace userCrud.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly UserContext _context;

    public UserController()
    {
        _context = new UserContext();
    }
    
    [HttpGet("{id}")]
    [ProducesResponseType<User>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetUser(int id)
    {
        try
        {
            User user = _context.Users.Where(u => u.ID == id).First();
            return Ok(user);  
        }
        catch (Exception e)
        {
            return NotFound();
        }

          }

    [HttpPut]
    [ProducesResponseType<User>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult UpdateUser([FromBody]User user)
    {
        try
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return Ok(user);
        }
        catch (Exception e)
        {
            return NotFound();
        }
    }
    
    [HttpPatch]
    [ProducesResponseType<User>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult UpdateUserLastName([FromQuery]int ID, [FromQuery]string LastName)
    {
        try
        {
            User user = _context.Users.Where(u => u.ID == ID).First();
            user.LastName = LastName;
            _context.Users.Update(user);
            _context.SaveChanges();
            return Ok(user);
        }
        catch (Exception e)
        {
            return NotFound();
        }

    }
    
    [HttpPost]
    [ProducesResponseType<User>(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult CreateUser([FromBody]User user)
    {
        try
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreateUser(user);
        }
        catch (Exception e)
        {
            return Conflict();
        }
    }
    [HttpDelete]
    [ProducesResponseType<User>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteUser([FromHeader]int ID)
    {
        try
        {
            User user = _context.Users.Where(u => u.ID == ID).First();
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok();
        }
        catch (Exception e)
        {
            return NotFound();
        }
    }
}