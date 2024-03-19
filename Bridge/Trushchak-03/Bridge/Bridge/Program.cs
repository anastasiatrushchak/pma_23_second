using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Shape square = new Square(-5, new Red());
                    square.Draw();
                    Console.WriteLine($"Area: {square.GetArea()}, Perimeter: {square.GetPerimeter()}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Shape rectangle = new Rectangle(4, 6, new Blue());
                rectangle.Draw();
                Console.WriteLine($"Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");

                Shape circle = new Circle(3, new Green());
                circle.Draw();
                Console.WriteLine($"Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");

                Shape triangle = new Triangle(3, 4, 5, new Blue());
                triangle.Draw();
                Console.WriteLine($"Area: {triangle.GetArea()}, Perimeter: {triangle.GetPerimeter()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
