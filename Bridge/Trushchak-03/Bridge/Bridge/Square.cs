using System;

namespace Bridge
{
    class Square : Rectangle 
    {
        public Square(double side, IColor color) : base(side, side, color)
        {
           
        }

       
    }
}
