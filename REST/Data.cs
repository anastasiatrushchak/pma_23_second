using System.ComponentModel.DataAnnotations;

namespace UserApi.Models
{
    public class Data
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
