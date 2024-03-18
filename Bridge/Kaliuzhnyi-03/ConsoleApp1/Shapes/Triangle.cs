using Bridge.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes;
public class Triangle : Shape
{
    private readonly double _sideOne;
    private readonly double _sideTwo;
    private readonly double _sideThree;

    public Triangle(double sideOne, double sideTwo, double sideThree, IColor color) : base(color)
    {
        if ((sideOne + sideTwo) <= sideThree || (sideOne + sideThree) <= sideTwo || (sideTwo + sideThree) <= sideOne)
        {
            throw new ArgumentException("Error! Sum of triangle's two sides can't be smaller or equal to the third!");
        }

        if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
        {
            throw new ArgumentException("Error! Triangle's side can't be smaller or equal to zero!");
        }

        _sideOne = sideOne;
        _sideTwo = sideTwo;
        _sideThree = sideThree;
    }

    public override double Area()
    {
        double p = Perimeter() / 2;

        return Math.Sqrt(p * (p - _sideOne) * (p - _sideTwo) * (p - _sideThree));
    }

    public override double Perimeter()
    {
        return _sideOne + _sideTwo + _sideThree;
    }

    public override string ToString()
    {
        string triangleToString = $"There is triangle with sides: {_sideOne}, {_sideTwo}, {_sideThree}; color: {Color}";

        return triangleToString;
    }
}
