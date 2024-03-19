using System;

namespace BridgePattern
{
    abstract class Shape
    {
        protected string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Draw();
    }
}
