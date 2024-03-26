abstract class Furniture
{
    protected internal string _style;

    public Furniture(string style)
    {
        _style = style;
    }

    public abstract string GetName();
}