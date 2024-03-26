class Chair : Furniture
{
    public Chair(string style) : base(style) { }

    public override string GetName()
    {
        return $"Chair ({_style} style)";
    }
}