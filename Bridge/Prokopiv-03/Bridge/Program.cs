using System;
using Bridge.Colors;
using Bridge.Shapes;

namespace Bridge;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            Square square = new Square(5);
            Blue blue = new Blue();
            Bridge blueSquare = new Bridge(square, blue);
            Console.WriteLine(blueSquare.Info());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        try
        {
            Rectangle rectangle = new Rectangle(4, 6);
            Red red = new Red();
            Bridge redRectangle = new Bridge(rectangle, red);
            Console.WriteLine(redRectangle.Info());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        
        try
        {
            Triangle triangle = new Triangle(8, 8, 5);
            Blue blue = new Blue();
            Bridge circleBlue = new Bridge(triangle, blue);
            Console.WriteLine(circleBlue.Info());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}