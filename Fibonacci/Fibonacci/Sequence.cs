using System;
using System.Collections.Generic;

class Fibonacci
{
    private int limit;
    private List<int> fibonacciSeries;

    public Fibonacci(int limit, int firstNumber, int secondNumber)
    {
        this.limit = limit;
        this.fibonacciSeries = new List<int> { firstNumber, secondNumber };
    }

    public void GenerateFibonacciSeries()
    {
        Console.WriteLine("Fibonacci Series:");
        GenerateFibonacciRecursive(fibonacciSeries[0], fibonacciSeries[1]);
        Console.WriteLine($"\nNumber of steps: {fibonacciSeries.Count - 2}");
    }

    private void GenerateFibonacciRecursive(int a, int b)
    {
        Console.Write($"{a} ");

        int nextNumber = a + b;
        if (nextNumber <= limit)
        {
            fibonacciSeries.Add(nextNumber);
            GenerateFibonacciRecursive(b, nextNumber);
        }
        else
        {
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the limit: ");
        int limit = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Fibonacci fibonacci = new Fibonacci(limit, firstNumber, secondNumber);
        fibonacci.GenerateFibonacciSeries();
    }
}
