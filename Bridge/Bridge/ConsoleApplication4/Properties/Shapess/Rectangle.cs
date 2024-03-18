using System;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height, IColor color) : base(color)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Width and height must be positive.");
            }
            this.width = width;
            this.height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.Fill()} rectangle with width {width} and height {height}");
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
}