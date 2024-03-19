using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shape
{
    public class Square : Rectangle
    {
        public Square(double side, Bridge.Color.Color color) : base(side, side, color)
        {
        }
        public override double getPerimeter()
        {
            if (width <= 0)
            {
                throw new Exception("Sides must be positive");
            }
            try
            {
                return 4 * width;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public override double getArea()
        {
            if (width <= 0)
            {
                throw new Exception("Sides must be positive");
            }
            try
            {
                return width * width;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }


    }
}

