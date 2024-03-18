using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Round : Shape
    {
        private double r;

        public Round(double r, MyColor color) : base(color)
        {
            if (r < 0)
                throw new ArgumentException("Radius cannot be negative");

            this.r = r;
        }

        public override void Create()
        {
            Console.WriteLine($"Create Round in {color.Filling()} color");
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }

        public override double Per()
        {
            return 2 * Math.PI * r;
        }
    }
}
