class ModernFurnitureFactory : FurnitureFactory
{
    public override Furniture CreateChair()
    {
        return new Chair("Modern");
    }

    public override Furniture CreateSofa()
    {
        return new Sofa("Modern");
    }

    public override Furniture CreateTable()
    {
        return new Table("Modern");
    }
}