using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Car : ICarFlyweight
    {
        private string brand;

        public Car(string brand)
        {
            this.brand = brand;
        }

        public void Drive(string color)
        {
            Console.WriteLine($"Driving a {color} {brand} car.");
        }
    }
}
