using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
        class Square : Rectangle
        { 
    
        private double sideD;

        public Square(double sideD, MyColor color) : base(color)
        {
            if (sideD < 0)
                throw new ArgumentException("Side length cannot be negative");

            this.sideD = sideD;
        }

        public Square(MyColor color) : base(color)
        {
        }

        public override void Create()
        {
            Console.WriteLine($"Create Square in {color.Filling()} color");
        }

        public override double Area()
        {
            return sideD * sideD;
        }

        public override double Per()
        {
            return sideD * 4;
        }
         }
}
