using System;

namespace Bridge
{
    class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3, IColor color) : base(color)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double GetArea()
        {
            try
            {
                
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                    throw new ArgumentException("All sides of a triangle must be positive.");

                
                double semiPerimeter = (side1 + side2 + side3) / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
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
                
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                    throw new ArgumentException("All sides of a triangle must be positive.");

                return side1 + side2 + side3;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error calculating perimeter: {ex.Message}");
                return 0;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.GetColor()} triangle with sides {side1}, {side2}, {side3}");
        }
    }
}
