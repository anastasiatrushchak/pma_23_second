using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Square : Rectangle
    {
        double side;

        public Square(double _side, Color color) : base(color)
        {
            if (_side < 0)
            {
                throw new Exception("Side square must be positive");
            }
            this.side = _side;
        }

        public override double Perimeter()
        {

            return 4 * side;

        }

        public override double Area()
        {

            return side * side;
        }
    }
}
