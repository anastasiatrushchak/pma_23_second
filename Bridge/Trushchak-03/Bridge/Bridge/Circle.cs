using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius, IColor color) : base(color)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            try
            {
                if (radius <= 0)
                    throw new ArgumentException("Radius of a circle must be positive.");

                return Math.PI * radius * radius;
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
                if (radius <= 0)
                    throw new ArgumentException("Radius of a circle must be positive.");

                return 2 * Math.PI * radius;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error calculating perimeter: {ex.Message}");
                return 0;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.GetColor()} circle with radius {radius}");
        }
    }


}
