using System;

class House
{
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Windows { get; set; }
    public string Doors { get; set; }
    public string ExtraFeature { get; set; }

    public void Display()
    {
        Console.WriteLine("House with the following features:");
        Console.WriteLine("Walls: " + Walls);
        Console.WriteLine("Roof: " + Roof);
        Console.WriteLine("Windows: " + Windows);
        Console.WriteLine("Doors: " + Doors);
        if (!string.IsNullOrEmpty(ExtraFeature))
            Console.WriteLine("Extra Feature: " + ExtraFeature);
        Console.WriteLine();
    }
}

abstract class HouseBuilder
{
    protected House house = new House();

    public abstract void BuildWalls();
    public abstract void BuildRoof();
    public abstract void BuildWindows();
    public abstract void BuildDoors();
    public abstract void AddExtraFeature();

    public House GetHouse()
    {
        return house;
    }
}

class StandardHouseBuilder : HouseBuilder
{
    public override void BuildWalls()
    {
        house.Walls = "Brick";
    }

    public override void BuildRoof()
    {
        house.Roof = "Tiles";
    }

    public override void BuildWindows()
    {
        house.Windows = "Glass";
    }

    public override void BuildDoors()
    {
        house.Doors = "Wooden";
    }

    public override void AddExtraFeature()
    {
        
    }
}

class HouseWithGarageBuilder : HouseBuilder
{
    public override void BuildWalls()
    {
        house.Walls = "Brick";
    }

    public override void BuildRoof()
    {
        house.Roof = "Tiles";
    }

    public override void BuildWindows()
    {
        house.Windows = "Glass";
    }

    public override void BuildDoors()
    {
        house.Doors = "Wooden";
    }

    public override void AddExtraFeature()
    {
        house.ExtraFeature = "Garage";
    }
}

class HouseWithTerraceBuilder : HouseBuilder
{
    public override void BuildWalls()
    {
        house.Walls = "Brick";
    }

    public override void BuildRoof()
    {
        house.Roof = "Tiles";
    }

    public override void BuildWindows()
    {
        house.Windows = "Glass";
    }

    public override void BuildDoors()
    {
        house.Doors = "Wooden";
    }

    public override void AddExtraFeature()
    {
        house.ExtraFeature = "Terrace";
    }
}

class Director
{
    private HouseBuilder houseBuilder;

    public Director(HouseBuilder builder)
    {
        houseBuilder = builder;
    }

    public void ConstructHouse()
    {
        houseBuilder.BuildWalls();
        houseBuilder.BuildRoof();
        houseBuilder.BuildWindows();
        houseBuilder.BuildDoors();
        houseBuilder.AddExtraFeature();
    }
}

class Program
{
    static void Main(string[] args)
    {
        HouseBuilder standardHouseBuilder = new StandardHouseBuilder();
        HouseBuilder houseWithGarageBuilder = new HouseWithGarageBuilder();
        HouseBuilder houseWithTerraceBuilder = new HouseWithTerraceBuilder();

        Director director = new Director(standardHouseBuilder);

        director.ConstructHouse();
        House standardHouse = standardHouseBuilder.GetHouse();
        standardHouse.Display();

        director = new Director(houseWithGarageBuilder);
        director.ConstructHouse();
        House houseWithGarage = houseWithGarageBuilder.GetHouse();
        houseWithGarage.Display();

        director = new Director(houseWithTerraceBuilder);
        director.ConstructHouse();
        House houseWithTerrace = houseWithTerraceBuilder.GetHouse();
        houseWithTerrace.Display();

        Console.ReadLine();
    }
}
