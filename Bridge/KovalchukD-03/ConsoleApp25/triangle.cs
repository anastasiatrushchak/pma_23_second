using System;

namespace BridgePattern
{
    class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC, string color) : base(color)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0 || !IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Invalid sides for a triangle.");
            }

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public override double Area()
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new InvalidOperationException("Cannot calculate area for an invalid triangle.");
            }

            double s = (sideA + sideB + sideC) / 2;

            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return Math.Round(area, 3);
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle: Perimeter={Perimeter()}, Area={Area()}, Color={color}");
        }
    }
}
