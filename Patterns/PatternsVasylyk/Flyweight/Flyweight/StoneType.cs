namespace Flyweight;

class StoneType
{
    public string Name;
    public string Color;
    public string Origin;

    public StoneType(string name, string color, string origin)
    {
        Name = name;
        Color = color;
        Origin = origin;
    }

    public void Draw(int weight)
    {
        Console.WriteLine($"Stone with {Color} color and {Origin} origin, named {Name} with weigth {weight}");
    }
}