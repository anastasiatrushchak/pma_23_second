using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Rectangle : Shape
    {
        double a;
        double b;
        public override double CalculatePerimetr()
        {
            return Math.Round(2 * (a + b), 2);
        }
        public override double CalculateArea()
        {
            return Math.Round(a * b, 2);
        }
        public Rectangle(double a, double b, Color color) : base(color)
        {
            A = a;
            B = b;
        }

        public Rectangle(Color color) : base(color)
        {
        }

        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side A can't be <= 0!");
                }
                a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side B can't be <= 0!");
                }
                b = value;
            }
        }
        public override void Info()
        {
            Console.Write("Shape: Rectangle ");
            base.Info();
        }
    }
}
