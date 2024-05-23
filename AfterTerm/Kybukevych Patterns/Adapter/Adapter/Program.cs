using System;

interface ITarget
{
    void Request();
}

class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request");
    }
}

class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public void Request()
    {
        _adaptee.SpecificRequest();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();

        ITarget target = new Adapter(adaptee);

        target.Request();

    }
}