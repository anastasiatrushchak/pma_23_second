using System;

// Product interface
interface IProduct
{
    void Operation();
}

// Concrete Product
class ConcreteProduct : IProduct
{
    public void Operation()
    {
        Console.WriteLine("ConcreteProduct operation");
    }
}

// Creator abstract class
abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

// Concrete Creator
class ConcreteCreator : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Client code
        Creator creator = new ConcreteCreator();
        IProduct product = creator.FactoryMethod();
        product.Operation();
    }
}
