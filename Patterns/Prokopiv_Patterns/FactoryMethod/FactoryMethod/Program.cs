using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        FurnitureFactory victorianFactory = new VictorianFurnitureFactory();
        FurnitureFactory industrialFactory = new IndustrialFurnitureFactory();
        FurnitureFactory modernFactory = new ModernFurnitureFactory();

        Order order = new Order();
        order.AddFurniture(victorianFactory.CreateChair());
        order.AddFurniture(industrialFactory.CreateSofa());
        order.AddFurniture(modernFactory.CreateTable());

        order.DisplayOrder();
    }
}
