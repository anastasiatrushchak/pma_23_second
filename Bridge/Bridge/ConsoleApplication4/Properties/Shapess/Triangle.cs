using System;

namespace Shapes
{
    public class Triangle:Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3, IColor color) : base(color)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Side lengths must be positive.");
            }
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("Invalid triangle sides.");
            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.Fill()} triangle with sides {side1}, {side2}, {side3}");
        }

        public override double GetPerimeter()
        {
            return side1 + side2 + side3;
        }

        public override double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
    }
}