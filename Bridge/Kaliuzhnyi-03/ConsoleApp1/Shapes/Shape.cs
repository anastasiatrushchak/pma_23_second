using Bridge.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes;
public abstract class Shape
{
    protected IColor _color;
    public string Color { get => _color.GetColor(); }
    public Shape(IColor color)
    {
        if (color == null)
        {
            throw new ArgumentNullException("Error! Color can't be null!");
        }
        _color = color;
    }
    public abstract double Perimeter();
    public abstract double Area();
}
