using System;

abstract class Shape
{
    protected IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract void Draw();
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius, IColor color) : base(color)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {color.ColorName} circle with radius {radius}");
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Square : Shape
{
    private double side;

    public Square(double side, IColor color) : base(color)
    {
        this.side = side;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {color.ColorName} square with side {side}");
    }

    public override double GetArea()
    {
        return side * side;
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }
}

interface IColor
{
    string ColorName { get; }
}

class RedColor : IColor
{
    public string ColorName => "Red";
}

class BlueColor : IColor
{
    public string ColorName => "Blue";
}

class Program
{
    static void Main(string[] args)
    {
        Shape redCircle = new Circle(5, new RedColor());
        Shape blueSquare = new Square(4, new BlueColor());

        redCircle.Draw();
        Console.WriteLine($"Area of red circle: {redCircle.GetArea()}");
        Console.WriteLine($"Perimeter of red circle: {redCircle.GetPerimeter()}");

        blueSquare.Draw();
        Console.WriteLine($"Area of blue square: {blueSquare.GetArea()}");
        Console.WriteLine($"Perimeter of blue square: {blueSquare.GetPerimeter()}");

        Console.ReadLine();
    }
}
