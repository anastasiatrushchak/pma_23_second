using Bridge.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes;

public class Square : Rectangle
{
    public Square(double side, IColor color) : base(side, side, color)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Error! Square's side can't be smaller or equal to zero!");
        }

    }
    public override string ToString()
    {
        string squareToString = $"There is square with side = {_sideOne} and {Color} color";

        return squareToString;
    }

}
