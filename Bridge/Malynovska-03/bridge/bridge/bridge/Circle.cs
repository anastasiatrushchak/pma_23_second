using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Circle : Shape
    {
        private double r;
        public override double CalculatePerimetr()
        {
            return Math.Round(2 * Math.PI * r, 2);
        }
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * r * r, 2);
        }
        public Circle(double r, Color color) : base(color)
        {
            Radius = r;
        }
        public double Radius
        {
            get { return r; }
            set { if (value <= 0)
                {
                    throw new ArgumentException("Radius can't be <= 0!");
                }
                r = value; }
        }
      
        public override void Info()
        {
            Console.Write("Shape: Circle ");
            base.Info();
        }
    }
}
