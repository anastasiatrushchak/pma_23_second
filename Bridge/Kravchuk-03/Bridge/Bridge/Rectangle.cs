using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Rectangle : Shape
    {
        private double len;
        private double wigh;

        public Rectangle(double len, double wigh, MyColor color) : base(color)
        {
            if (len < 0 || wigh < 0)
                throw new ArgumentException("Dimensions cannot be negative");

            this.len = len;
            this.wigh = wigh;
        }

        public Rectangle(MyColor color) : base(color)
        {
        }

        public override void Create()
        {
            Console.WriteLine($"Create Rectangle in {color.Filling()} color ");
        }

        public override double Area()
        {
            return len * wigh;
        }

        public override double Per()
        {
            return 2 * (len + wigh);
        }
    }
}
