using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.AbstractFactory.Cars
{
    internal class VolvoCar : ICar
    {
        public string Type { get; set; }
        private string _sound;
        

        public VolvoCar(string type, string sound)
        {
            Type = type;
            _sound = sound;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm just Volvo car, I use {Type} and go {_sound}");
        }
    }
}
