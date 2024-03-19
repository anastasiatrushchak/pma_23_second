using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public abstract class Shape
    {
        private Color color;
        public abstract double CalculatePerimetr();
        public abstract double CalculateArea();

        public Shape(Color color)
        {
            this.color = color;
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public virtual void Info()
        {
            Console.WriteLine($"\nColor: {color.Paint()}, Perimetr: {CalculatePerimetr()}, Area: {CalculateArea()}\n");
        }
    }
}
