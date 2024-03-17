using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(Colour colour, double radius) : base(colour)
        {
            if (radius > 0)
                this.radius = radius;
            else
                Console.WriteLine("Error: Radius of circle must be a positive number");
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
