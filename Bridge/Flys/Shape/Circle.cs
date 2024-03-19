using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Color;


namespace Bridge.Shape
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius,Bridge.Color.Color color) : base(color)
        {
            this.radius = radius;

        }
        public override double getPerimeter()
        {
            if (radius <= 0)
            {
                throw new Exception("Radius must be positive");
            }
            try
            {
                return 2 * Math.PI * radius;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public override double getArea()
        {
            if (radius <= 0)
            {
                throw new Exception("Radius must be positive");
            }
            try
            {
                return Math.PI * radius * radius;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public override void draw()
        {
            Console.WriteLine("Drawing a circle");
            color.applyColor();
        }
    }
}
