public abstract class Figure
{
    public Color color;

    public Figure(Color color)
    {
        this.color = color;
    }

    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
}

public class Rectangle : Figure
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(Color color, double width, double height) : base(color)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentException("Width and height must be positive numbers.");
        }

        Width = width;
        Height = height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}
public class Square : Figure
{
    public double Side { get; }

    public Square(Color color, double side) : base(color)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Side must be a positive number.");
        }

        Side = side;
    }

    public override double CalculatePerimeter()
    {
        return 4 * Side;
    }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}
public class Triangle : Figure
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(Color color, double a, double b, double c) : base(color)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Sides must be positive numbers.");
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("The sum of any two sides of a triangle must be greater than the third side.");
        }

        A = a;
        B = b;
        C = c;
    }

    public override double CalculatePerimeter()
    {
        return A + B + C;
    }

    public override double CalculateArea()
    {
        double s = CalculatePerimeter() / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
}
public class Circle : Figure
{
    public double Radius { get; }

    public Circle(Color color, double radius) : base(color)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive number.");
        }

        Radius = radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}