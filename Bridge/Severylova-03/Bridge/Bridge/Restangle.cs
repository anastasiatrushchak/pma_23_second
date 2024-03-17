using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Rectangle : Shape
    {
        double height;
        double width;

        public Rectangle(double _height, double _width, Color color) : base(color)
        {
            if (_height < 0 || _width < 0)
            {
                throw new Exception("All sides restangle must be positive");

            }
            this.height = _height;
            this.width = _width;
        }

        public Rectangle(Color color) : base(color)
        {
        }

        public override double Perimeter()
        {

            return 2 * height + 2 * width;
        }

        public override double Area()
        {
            return height * width;

        }
    }
}
