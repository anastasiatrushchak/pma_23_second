using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Shape
    {
        protected MyColor color;

        public Shape(MyColor color)
        {
            this.color = color;
        }

        public abstract void Create();
        public abstract double Area();
        public abstract double Per();
    }

}
