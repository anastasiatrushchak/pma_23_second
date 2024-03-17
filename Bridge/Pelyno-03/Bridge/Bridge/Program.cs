using System;
using System.Net.NetworkInformation;
using Bridge;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour pink = new Pink();
            Colour green = new Green();
            Colour purple = new Purple();
            Colour blue = new Blue();

            Figure purpleCircle = new Circle(purple, 8);
            Figure greenRectangle = new Rectangle(green, 6, 4);
            Figure pinkSquare = new Square(pink, 8);
            Figure blueTriangle = new Triangle(blue, 3, 4, 5);

            Console.WriteLine(purpleCircle);
            Console.WriteLine(greenRectangle);
            Console.WriteLine(pinkSquare);
            Console.WriteLine(blueTriangle);
        }
    }
}
