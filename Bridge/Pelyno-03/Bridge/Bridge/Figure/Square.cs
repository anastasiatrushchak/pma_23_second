using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Square : Rectangle
    {
        public Square(Colour colour, double side) : base(colour, side, side)
        {
            
        }
    }
}
