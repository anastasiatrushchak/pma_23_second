using System;
using Bridge.Colors;
using Bridge.Shapes;

namespace Bridge

{
    public class Bridge
    {
        private Shape shape;
        private Color color;

        public Bridge(Shape shape, Color color)
        {
            this.shape = shape;
            this.color = color;
        }

        public string Info()
        {
            return $"{color.GetColor()} {shape} [Area = {shape.CalculateArea()} Perimeter = {shape.CalculatePerimeter()}]";
        }
    }
}