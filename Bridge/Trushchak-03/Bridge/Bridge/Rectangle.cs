using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width, IColor color) : base(color)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            try
            {
                if (length <= 0 || width <= 0)
                    throw new ArgumentException("Sides of a rectangle must be positive.");

                return length * width;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error calculating area: {ex.Message}");
                return 0;
            }
        }

        public override double GetPerimeter()
        {
            try
            {
                if (length <= 0 || width <= 0)
                    throw new ArgumentException("Sides of a rectangle must be positive.");

                return 2 * (length + width);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error calculating perimeter: {ex.Message}");
                return 0;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.GetColor()} square  with length {length} and width {width}");
        }
    }
}
