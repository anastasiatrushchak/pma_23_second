using System;

namespace BridgePattern
{
    class Rectangle : Shape
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB, string color) : base(color)
        {
            if (sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentException("Sides must be positive numbers.");
            }

            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double Area()
        {
            return sideA * sideB;
        }

        public override double Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle: Perimeter={Perimeter()}, Area={Area()}, Color={color}");
        }
    }
}
