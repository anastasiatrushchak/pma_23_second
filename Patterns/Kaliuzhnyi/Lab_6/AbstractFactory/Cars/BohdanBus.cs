using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.AbstractFactory.Cars
{
    internal class BohdanBus : IBus
    {
        public string Type { get; set; }
        private string _sound;
        private int _passengers;

        public BohdanBus(string type, int passengers)
        {
            Type = type;
            if (type == "gas")
            {
                _sound = "BRUUU";
            }
            else
            {
                _sound = "...";
            }
            _passengers = passengers;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm bus Bohdan,I can deliver {_passengers} people, I use {Type} and go {_sound}");
        }

        public void DeliverPassengers()
        {
            Console.WriteLine($"I'm delivering {_passengers} people!");
        }
    }
}
