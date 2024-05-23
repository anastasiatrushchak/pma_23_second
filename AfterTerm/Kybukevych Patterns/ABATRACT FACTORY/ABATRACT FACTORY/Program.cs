using System;

abstract class AbstractProductA
{
    public abstract void Interact(AbstractProductB b);
}

abstract class AbstractProductB
{
    public abstract void Interact(AbstractProductA a);
}

class ProductA1 : AbstractProductA
{
    public override void Interact(AbstractProductB b)
    {
        Console.WriteLine($"{this.GetType().Name} interacts with {b.GetType().Name}");
    }
}

class ProductA2 : AbstractProductA
{
    public override void Interact(AbstractProductB b)
    {
        Console.WriteLine($"{this.GetType().Name} interacts with {b.GetType().Name}");
    }
}

class ProductB1 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
    }
}

class ProductB2 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
    }
}

abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}

class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}

class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}

class Client
{
    private AbstractProductA _productA;
    private AbstractProductB _productB;

    public Client(AbstractFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void Run()
    {
        _productA.Interact(_productB);
        _productB.Interact(_productA);
    }
}

class Program
{
    static void Main(string[] args)
    {
        AbstractFactory factory1 = new ConcreteFactory1();
        Client client1 = new Client(factory1);
        client1.Run();

        AbstractFactory factory2 = new ConcreteFactory2();
        Client client2 = new Client(factory2);
        client2.Run();
    }
}
