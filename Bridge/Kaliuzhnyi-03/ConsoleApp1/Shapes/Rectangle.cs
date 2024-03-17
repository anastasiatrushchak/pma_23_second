using Bridge.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes;
public class Rectangle : Shape
{
    protected readonly double _sideOne;
    protected readonly double _sideTwo;

    public Rectangle(double sideOne, double sideTwo, IColor color) : base(color)
    {
        if (sideOne <= 0 || sideTwo <= 0)
        {
            throw new ArgumentException("Error! Rectangle's side can't be smaller or equal to zero!");
        }

        _sideOne = sideOne;
        _sideTwo = sideTwo;
    }

    public override double Area()
    {
        return _sideOne * _sideTwo;
    }

    public override double Perimeter()
    {
        return (_sideOne + _sideTwo) * 2;
    }

    public override string ToString()
    {
        string rectangleToString = $"There is rectangle with sides: {_sideOne}, {_sideTwo}; color: {Color}";

        return rectangleToString;
    }

}
