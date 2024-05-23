using System;

public interface IStrategy
{
    void Execute();
}

public class ConcreteStrategy1 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy 1");
    }
}

public class ConcreteStrategy2 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy 2");
    }
}

public class Context
{
    private IStrategy strategy;

    public Context(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        strategy.Execute();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var context = new Context(new ConcreteStrategy1());
        context.ExecuteStrategy();
        
        context.SetStrategy(new ConcreteStrategy2());
        context.ExecuteStrategy();
    }
}
