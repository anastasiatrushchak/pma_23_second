public abstract class Bridge
{
    protected Figure figure;

    public Bridge(Figure figure)
    {
        this.figure = figure;
    }

    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public abstract string GetColor();
}

public class SquareBridge : Bridge
{
    public SquareBridge(Square square) : base(square) { }

    public override double CalculatePerimeter()
    {
        return figure.CalculatePerimeter();
    }

    public override double CalculateArea()
    {
        return figure.CalculateArea();
    }
    public override string GetColor()
    {
        return ((Color)figure.color).Name;
    }
}

public class RectangleBridge : Bridge
{
    public RectangleBridge(Rectangle rectangle) : base(rectangle) { }

    public override double CalculatePerimeter()
    {
        return figure.CalculatePerimeter();
    }

    public override double CalculateArea()
    {
        return figure.CalculateArea();
    }
    public override string GetColor()
    {
        return ((Color)figure.color).Name;
    }
}

public class TriangleBridge : Bridge
{
    public TriangleBridge(Triangle triangle) : base(triangle) { }

    public override double CalculatePerimeter()
    {
        return figure.CalculatePerimeter();
    }

    public override double CalculateArea()
    {
        return figure.CalculateArea();
    }
    public override string GetColor()
    {
        return ((Color)figure.color).Name;
    }
}

public class CircleBridge : Bridge
{
    public CircleBridge(Circle circle) : base(circle) { }

    public override double CalculatePerimeter()
    {
        return figure.CalculatePerimeter();
    }

    public override double CalculateArea()
    {
        return figure.CalculateArea();
    }
    public override string GetColor()
    {
        return ((Color)figure.color).Name;
    }
}