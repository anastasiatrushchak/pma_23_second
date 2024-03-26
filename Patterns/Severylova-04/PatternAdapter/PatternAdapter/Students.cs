using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    public class Students
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public string Age { get; set; }

        public string Email {  get; set; }
        
        public Students(string name, string surname, string age, string email)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
        }

    }
}
