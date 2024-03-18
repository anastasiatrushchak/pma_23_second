using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Circle : Shape
    {
        const double PI = 3.14;
        public double radius;

        public Circle(double _radius, Color color) : base(color)
        {
            if (_radius < 0)
            {
                throw new Exception("Radius must be positive");
            }
            this.radius = _radius;
        }

        public override double Perimeter()
        {
            return 2 * PI * radius;
        }

        public override double Area()
        {
            return PI * Math.Pow(radius, 2);
        }
    }
}
