using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Bridge.Color;

namespace Bridge.Shape
{
    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;
        public Triangle(double side1, double side2, double side3, Bridge.Color.Color color) : base(color)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double getPerimeter()
        {
            return side1 + side2 + side3;
        }
        public override double getArea()
        {
            if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            {
                throw new Exception("Sides do not form a triangle");
            }
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new Exception("Sides must be positive");
            }
            try
            {
                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public override void draw()
        {
            Console.WriteLine("Drawing a triangle");
            color.applyColor();
        }
    }
}
