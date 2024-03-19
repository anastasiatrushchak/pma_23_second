using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Colors
{
    public abstract class Color
    {
        protected string color;

        public Color(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }
    }
}




