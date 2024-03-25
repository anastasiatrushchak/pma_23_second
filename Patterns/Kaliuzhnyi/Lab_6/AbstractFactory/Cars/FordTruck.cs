using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.AbstractFactory.Cars
{
    internal class FordTruck : ITruck
    {
        public string Type {  get; set; }
        private string _sound;
        private double _weigh;

        public FordTruck(string type, string sound, double weigh)
        {
            Type = type;
            _sound = sound;
            _weigh = weigh;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm Truck Ford,I can deliver {_weigh} tons of products, I use {Type} and go {_sound}");
        }

        public void DeliverProduct()
        {
            Console.WriteLine($"I'm delivering {_weigh} tons of product!");
        }
    }
}
