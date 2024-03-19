using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Square : Rectangle
    {
        double a;
        public override double CalculatePerimetr()
        {
            return Math.Round(4 * a, 2);
        }
        public override double CalculateArea()
        {
            return Math.Round(a * a, 2);
        }
        public Square(double a, Color color) : base(color) 
        {
            A = a;
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
        public override void Info()
        {
            Console.Write("Shape: Square ");
            base.Info();
        }
    }
}
