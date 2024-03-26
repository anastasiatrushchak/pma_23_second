class IndustrialFurnitureFactory : FurnitureFactory
{
    public override Furniture CreateChair()
    {
        return new Chair("Industrial");
    }

    public override Furniture CreateSofa()
    {
        return new Sofa("Industrial");
    }

    public override Furniture CreateTable()
    {
        return new Table("Industrial");
    }
}
