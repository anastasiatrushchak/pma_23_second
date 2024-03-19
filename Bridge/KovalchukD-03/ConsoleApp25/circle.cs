using System;

namespace BridgePattern
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius, string color) : base(color)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be a positive number.");
            }

            this.radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * radius * radius, 3);
        }

        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI * radius, 3);
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle: Perimeter={Perimeter()}, Area={Area()}, Color={color}");
        }
    }
}
