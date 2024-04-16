using System.Collections.ObjectModel;

namespace userCrud.Models;

public class User
{
    public int ID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName{ get; set; }
    public virtual ICollection<Message> Messages { get; set; }



}