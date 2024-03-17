using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Figure
    {
        protected Colour colour;

        public Figure(Colour colour)
        {
            this.colour = colour;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"{GetType().Name}: Colour: {colour.SetColour()}, Area = {Area()}, Perimeter = {Perimeter()}";
        }
    }
}
