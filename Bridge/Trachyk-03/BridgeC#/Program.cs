using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create figures
            Square square = new Square(new Red(), 5);
            Rectangle rectangle = new Rectangle(new Green(), 4, 6);
            Triangle triangle = new Triangle(new Blue(), 3, 4, 5);
            Circle circle = new Circle(new Red(), 2);

            // Create bridges
            SquareBridge squareBridge = new SquareBridge(square);
            RectangleBridge rectangleBridge = new RectangleBridge(rectangle);
            TriangleBridge triangleBridge = new TriangleBridge(triangle);
            CircleBridge circleBridge = new CircleBridge(circle);

            // Calculate perimeters and areas
            Console.WriteLine($"Figura: {triangle}");
            Console.WriteLine($"Perimeter: {triangleBridge.CalculatePerimeter()}");
            Console.WriteLine($"Area: {triangleBridge.CalculateArea()}");
            Console.WriteLine($"Color: {triangleBridge.GetColor()}\n");

            Console.WriteLine($"Figura: {rectangle}");
            Console.WriteLine($"Perimeter: {rectangleBridge.CalculatePerimeter()}");
            Console.WriteLine($"Area: {rectangleBridge.CalculateArea()}");
            Console.WriteLine($"Color: {rectangleBridge.GetColor()}\n");

            Console.WriteLine($"Figura: {square}");
            Console.WriteLine($"Perimeter: {squareBridge.CalculatePerimeter()}");
            Console.WriteLine($"Area: {squareBridge.CalculateArea()}");
            Console.WriteLine($"Color: {squareBridge.GetColor()}\n");

            Console.WriteLine($"Figura: {circle}");
            Console.WriteLine($"Perimeter: {circleBridge.CalculatePerimeter()}");
            Console.WriteLine($"Area: {circleBridge.CalculateArea()}");
            Console.WriteLine($"Color: {circleBridge.GetColor()}\n");
        }
    }
}
