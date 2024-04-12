using System;

class Program
{
    static void Main(string[] args)
    {
        // Об'єкти для кольорів
        IColor redColor = new RedColor();
        IColor blueColor = new BlueColor();

        // Об'єкти для фігур
        Shape redCircle = new Circle(5, redColor);
        Shape blueSquare = new Square(4, blueColor);
        Shape redRectangle = new Rectangle(3, 5, redColor);
        Shape blueTriangle = new Triangle(3, 4, 5, blueColor);

        // Вивід інформації
        Console.WriteLine(redCircle.Draw());
        Console.WriteLine($"Площа: {redCircle.GetArea()}, Периметр: {redCircle.GetPerimeter()}");

        Console.WriteLine(blueSquare.Draw());
        Console.WriteLine($"Площа: {blueSquare.GetArea()}, Периметр: {blueSquare.GetPerimeter()}");

        Console.WriteLine(redRectangle.Draw());
        Console.WriteLine($"Площа: {redRectangle.GetArea()}, Периметр: {redRectangle.GetPerimeter()}");

        Console.WriteLine(blueTriangle.Draw());
        Console.WriteLine($"Площа: {blueTriangle.GetArea()}, Периметр: {blueTriangle.GetPerimeter()}");
    }
}
