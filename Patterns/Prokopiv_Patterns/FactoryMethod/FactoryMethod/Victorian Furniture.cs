class VictorianFurnitureFactory : FurnitureFactory
{
    public override Furniture CreateChair()
    {
        return new Chair("Victorian");
    }

    public override Furniture CreateSofa()
    {
        return new Sofa("Victorian");
    }

    public override Furniture CreateTable()
    {
        return new Table("Victorian");
    }
}
