using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(Colour colour, double sideA, double sideB, double sideC) : base(colour)
        {
            if (IsValidTriangle(sideA, sideB, sideC))
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            else
                Console.WriteLine("Error: Invalid sides for a triangle");
        }
        private bool IsValidTriangle(double a, double b, double c)
        {
            
            return a + b > c && a + c > b && b + c > a;
        }

        public override double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }


    }
}
