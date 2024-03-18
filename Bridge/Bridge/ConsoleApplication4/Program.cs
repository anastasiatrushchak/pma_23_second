using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape redSquare = new Square(5, new RedColor());
                Shape blueRectangle = new Rectangle(3, 4, new BlueColor());
                Shape redTriangle = new Triangle(3, 4, 5, new RedColor());
                Shape blueCircle = new Circle(2.5, new BlueColor());

                redSquare.Draw();
                Console.WriteLine($"Area: {redSquare.GetArea()}, Perimeter: {redSquare.GetPerimeter()}");
                Console.WriteLine();

                blueRectangle.Draw();
                Console.WriteLine($"Area: {blueRectangle.GetArea()}, Perimeter: {blueRectangle.GetPerimeter()}");
                Console.WriteLine();

                redTriangle.Draw();
                Console.WriteLine($"Area: {redTriangle.GetArea()}, Perimeter: {redTriangle.GetPerimeter()}");
                Console.WriteLine();

                blueCircle.Draw();
                Console.WriteLine($"Area: {blueCircle.GetArea()}, Perimeter: {blueCircle.GetPerimeter()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}