using System;

namespace BridgePattern
{
    class Square : Rectangle
    {
        public Square(double side, string color) : base(side, side, color)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side must be a positive number.");
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"Square: Perimeter={Perimeter()}, Area={Area()}, Color={color}");
        }
    }
}
