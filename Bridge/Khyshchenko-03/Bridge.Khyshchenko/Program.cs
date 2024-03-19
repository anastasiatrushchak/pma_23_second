using System;

class Program
{
    static void Main(string[] args)
    {
        IColor redColor = new RedColor();
        IColor blueColor = new BlueColor();

        Shape redCircle = new Circle(5, redColor);
        Shape blueSquare = new Square(4, blueColor);
        Shape redRectangle = new Rectangle(3, 5, redColor);
        Shape blueTriangle = new Triangle(3, 4, 5, blueColor);

        Console.WriteLine(redCircle.Draw());
        Console.WriteLine($"Area: {redCircle.GetArea()}, Perimeter: {redCircle.GetPerimeter()}");

        Console.WriteLine(blueSquare.Draw());
        Console.WriteLine($"Area: {blueSquare.GetArea()}, Perimeter: {blueSquare.GetPerimeter()}");

        Console.WriteLine(redRectangle.Draw());
        Console.WriteLine($"Area: {redRectangle.GetArea()}, Perimeter: {redRectangle.GetPerimeter()}");

        Console.WriteLine(blueTriangle.Draw());
        Console.WriteLine($"Area: {blueTriangle.GetArea()}, Perimeter: {blueTriangle.GetPerimeter()}");
    }
}
