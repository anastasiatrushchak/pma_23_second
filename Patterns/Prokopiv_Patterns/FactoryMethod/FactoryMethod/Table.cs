class Table : Furniture
{
    public Table(string style) : base(style) { }

    public override string GetName()
    {
        return $"Table ({_style} style)";
    }
}