using System;

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
            Purple purple = new Purple();
            Bridge purpleRectangle = new Bridge(rectangle, purple);
            Console.WriteLine(purpleRectangle.Info());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        try
        {
            Circle circle = new Circle(-5);
            Yellow yellow = new Yellow();
            Bridge circleYellow = new Bridge(circle, yellow);
            Console.WriteLine(circleYellow.Info());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        try
        {
            Triangle triangle=new Triangle(8,8,5);
            Blue blue=new Blue();
            Bridge circleYellow = new Bridge(triangle, blue);
            Console.WriteLine(circleYellow.Info());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
