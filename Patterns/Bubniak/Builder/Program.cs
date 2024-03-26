using System;

class Product
{
    public string Part1 { get; set; }
    public string Part2 { get; set; }
}

interface IBuilder
{
    void BuildPart1();
    void BuildPart2();
    Product GetResult();
}

class ConcreteBuilder : IBuilder
{
    private Product product = new Product();

    public void BuildPart1()
    {
        product.Part1 = "Part 1 built";
    }

    public void BuildPart2()
    {
        product.Part2 = "Part 2 built";
    }

    public Product GetResult()
    {
        return product;
    }
}

class Director
{
    private IBuilder builder;

    public Director(IBuilder builder)
    {
        this.builder = builder;
    }

    public void Construct()
    {
        builder.BuildPart1();
        builder.BuildPart2();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IBuilder builder = new ConcreteBuilder();
        Director director = new Director(builder);
        director.Construct();
        Product product = builder.GetResult();

        Console.WriteLine("Product Parts: {0} and {1}", product.Part1, product.Part2);
    }
}
