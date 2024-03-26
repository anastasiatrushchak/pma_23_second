class Sofa : Furniture
{
    public Sofa(string style) : base(style) { }

    public override string GetName()
    {
        return $"Sofa ({_style} style)";
    }
}