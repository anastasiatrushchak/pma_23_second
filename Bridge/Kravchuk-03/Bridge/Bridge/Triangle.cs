using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    using System;

    namespace Bridge
    {
        class Triangle : Shape
        {
            private double sideA;
            private double sideB;
            private double sideC;

            public Triangle(double sideA, double sideB, double sideC, MyColor color) : base(color)
            {
                if (sideA < 0 || sideB < 0 || sideC < 0)
                    throw new ArgumentException("Dimensions cannot be negative");

                if (!IsTriangleValid(sideA, sideB, sideC))
                    throw new ArgumentException("Invalid triangle dimensions: sum of two sides must be greater than the third side");

                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }

            private bool IsTriangleValid(double a, double b, double c)
            {
                return a + b > c && a + c > b && b + c > a;
            }

            public override void Create()
            {
                Console.WriteLine($"Create Triangle in {color.Filling()} color");
            }

            public override double Area()
            {
                double p = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }

            public override double Per()
            {
                return sideA + sideB + sideC;
            }
        }
    }

}
