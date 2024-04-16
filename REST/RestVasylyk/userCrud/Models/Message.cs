using Microsoft.AspNetCore.Server.HttpSys;

namespace userCrud.Models;

public class Message
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public virtual User User { get; set; }
}