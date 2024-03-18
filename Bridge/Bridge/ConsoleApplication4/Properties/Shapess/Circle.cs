using System;

namespace Shapes
{
    public class Circle:Shape

    {
    private double radius;

    public Circle(double radius, IColor color) : base(color)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive.");
        }

        this.radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {color.Fill()} circle with radius {radius}");
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
}