using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Color
{
    public abstract string Name { get; }
}
public class Red : Color
{
    public override string Name => "Red";
}
public class Green : Color
{
    public override string Name => "Green";
}

public class Blue : Color
{
    public override string Name => "Blue";
}
