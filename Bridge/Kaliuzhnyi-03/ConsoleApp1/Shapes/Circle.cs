using Bridge.Colors;

namespace Bridge.Shapes;

public class Circle : Shape
{
    private readonly double _radius;
    public Circle(double radius, IColor color) : base(color)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Error! Radius can't be smaller or equal to zero!");
        }
        _radius = radius;
    }

    public override double Area()
    {
        return Math.Sqrt(_radius) * Math.PI;
    }

    public double Area(int roundPNumber)
    {
        if (roundPNumber < 0 || roundPNumber > 16)
        {
            throw new ArgumentException("Error! Rounding up is possible in range 0-16!");
        }
        return Math.Sqrt(_radius) * Math.Round(Math.PI, roundPNumber);
    }

    public override double Perimeter()
    {
        return 2 * _radius * Math.PI;
    }

    public double Perimeter(int roundPNumber)
    {
        if (roundPNumber < 0 || roundPNumber > 16)
        {
            throw new ArgumentException("Error! Rounding up is possible in range 0-16!");
        }
        return 2 * _radius * Math.Round(Math.PI, roundPNumber);
    }

    public override string ToString()
    {
        string circleToString = $"There is circle with radius = {_radius} and {Color} color";

        return circleToString;
    }
}
