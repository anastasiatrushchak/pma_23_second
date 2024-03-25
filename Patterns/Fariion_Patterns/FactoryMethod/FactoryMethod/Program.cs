using System;


namespace FactoryMethod;


class Program
{
    static void Client(CarFactory factory)
    {
        Car car = factory.CreateCar(); 
        Console.WriteLine(car.Drive());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Створення седана:");
        Client(new SedanFactory());
        Console.WriteLine();

        Console.WriteLine("Створення кросовера:");
        Client(new SUVFactory());
    }
}
