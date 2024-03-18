using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Shape
    {
        protected Color _color;
        public Shape(Color color) 
        {
            this._color = color;
        }
        public abstract double Perimeter();


        public abstract double Area();

        public override string ToString()
        {
            return $"Shape: {GetType().Name}, Color: {_color.GetColor()}, Area: {Area()}, Perimeter: {Perimeter()}";
        }
    }

    
}
