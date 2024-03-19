using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bridge
{
    public class Triangle : Shape
    {
        double a;
        double b;
        double c;
       
        public override double CalculatePerimetr()
        {
            return a + b + c;
        }
        public override double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }
        public Triangle(double a, double b,double c, Color color) : base(color)
        {
            A = a;
            B = b; 
            C = c;
            if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                throw new ArgumentException("Incorrect sides! It is impossible to create triangle!");
            }
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
                a  = value;
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
        public double C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side C can't be <= 0!");
                }
                c = value;
            }
        }

        public override void Info()
        {
            Console.Write("Shape: Triangle ");
            base.Info();
        }
    }
}
