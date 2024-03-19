using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Color;

namespace Bridge.Shape
{
    public abstract class Shape
    {
        protected Bridge.Color.Color color;

        public Shape(Bridge.Color.Color color)
        {
            this.color = color;
        }

        public abstract double getPerimeter();
        public abstract double getArea();
        public abstract void draw();
    }
}

