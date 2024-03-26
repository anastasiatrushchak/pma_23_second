using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public class Student : User
    {
        public string name { get; private set; }
        public Student(InterfaceChatMediator chatMediator, string name) : base(chatMediator)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be null or empty"); 
            }
            if (name.Any(char.IsDigit))
            {
                throw new ArgumentException("Name cannot contain numbers");
            }
            this.name = name;
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"{name} received: {message}");
        }
    }
}
