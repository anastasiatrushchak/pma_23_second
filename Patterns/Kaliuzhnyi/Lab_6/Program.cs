using Lab_6.AbstractFactory.Factory;
using Lab_6.Adapter.Adapter;
using Lab_6.Adapter.Adapter.Adapter;
using Lab_6.Adapter.Person;
using Lab_6.Strategy;
using Lab_6.Strategy.StrategyClasses;

public static class Program
{
    public static void Main(string[] args)
    {
        TestAbsFactory(new ElectroVehiclesFactory());
        Console.WriteLine();
        TestAbsFactory(new GasVehiclesFactory());
        Console.WriteLine();
        Console.WriteLine();
        TestAdapter();
        Console.WriteLine();
        TestStrategy();
    }

    static void TestAbsFactory(IVehicleFactory factory)
    {
        var bus = factory.CreateBus(50);
        bus.Drive();
        bus.DeliverPassengers();
        var car = factory.CreateCar();
        car.Drive();
        var truck = factory.CreateTruck(5.4);
        truck.Drive();
        truck.DeliverProduct();
    }

    static void TestAdapter()
    {
        string jsonFilename = "E:/Навчання_4_семестр/Програмування/Лабораторні/Lab_6/Lab_6/Adapter/Person/person.json";
        string xmlFilename = "E:/Навчання_4_семестр/Програмування/Лабораторні/Lab_6/Lab_6/Adapter/Person/person.txt";
        Person personOne = new Person(new JsonToString(jsonFilename));
        Console.WriteLine(personOne);
        Person personTwo = new Person(new TxtToJsonToString(xmlFilename));
        Console.WriteLine(personTwo);

    }

    static void TestStrategy()
    {
        Animal animal = new Animal(new DoRun());
        animal.DoStep();
        animal.ChangeStrategy(new DoEat());
        animal.DoStep();
        Animal animalTwo = new Animal();
        try
        {
            animalTwo.DoStep();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        animalTwo.ChangeStrategy(new DoMove());
        animalTwo.DoStep();

    }
}