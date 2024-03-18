using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Triangle : Shape
    {
        private double side_a;
        private double side_b;
        private double side_c;

        public Triangle(double _side_a, double _side_b, double _side_c, Color color) : base(color)
        {
            if (_side_a < 0 || _side_b < 0 || _side_c < 0)
            {
               throw new Exception("All sides must be positive");
            }

            this.side_a = _side_a;
            this.side_b = _side_b;
            this.side_c = _side_c;
        }

        public override double Perimeter()
        {
            return side_a + side_b + side_c;

        }

        public override double Area()
        {
            if (side_a + side_b <= side_c || side_c + side_b <= side_a || side_a + side_c <= side_b)
            {
                throw new Exception("It is impossible to create triangle");
                
            }
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - side_a) * (p - side_b) * (p - side_c));

        }


    }
}
