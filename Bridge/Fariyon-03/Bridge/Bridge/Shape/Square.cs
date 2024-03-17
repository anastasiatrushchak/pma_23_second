using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
    }
}
