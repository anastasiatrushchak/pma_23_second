using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(Colour colour, double width, double height) : base(colour)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
                Console.WriteLine("Error: Width and height must be positive numbers");
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }

}
