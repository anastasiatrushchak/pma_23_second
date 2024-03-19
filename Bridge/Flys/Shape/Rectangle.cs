using Bridge.Color;
using System;
using System.Drawing;
using Bridge.Shape;

namespace Bridge.Shape
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double height;

        public Rectangle(double width, double height, Bridge.Color.Color color) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double getPerimeter()
        {
            if (width <= 0 || height <= 0)
            {
                throw new Exception("Sides must be positive");
            }
            try
            {
                return 2 * (width + height);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public override double getArea()
        {
            if (width <= 0 || height <= 0)
            {
                throw new Exception("Sides must be positive");
            }
            try
            {
                return width * height;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public override void draw()
        {
            Console.WriteLine("Drawing a rectangle");
            color.applyColor();
        }
    }
}
