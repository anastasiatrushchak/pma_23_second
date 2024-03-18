using System;

namespace Shapes
{
    public class Square:Rectangle
    {
        public Square(double side, IColor color) : base(side, side, color)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side length must be positive.");
            }
        }
    }
}