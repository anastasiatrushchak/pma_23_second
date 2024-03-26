using System;

class Program
{
    static void Main(string[] args)
    {
        Dish pizza = new Pizza();
        pizza = new CheeseDecorator(pizza);
        Console.WriteLine("Ordered: " + pizza.GetDescription());
        Console.WriteLine("Cost: $" + pizza.GetCost());

        Console.WriteLine();

        Dish pasta = new Pasta();
        pasta = new VegetableDecorator(pasta); 
        pasta = new CheeseDecorator(pasta); 
        Console.WriteLine("Ordered: " + pasta.GetDescription());
        Console.WriteLine("Cost: $" + pasta.GetCost());
    }
}
