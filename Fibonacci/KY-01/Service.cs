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
        Console.WriteLine($"Fibonacci Series with {limit} steps:");

        for (int i = 2; i < limit; i++)
        {
            int result = CalculateFibonacci(i);
            fibonacciSeries.Add(result);
        }

        Console.WriteLine(string.Join(" ", fibonacciSeries));
    }

    private int CalculateFibonacci(int n)
    {
        return fibonacciSeries[n - 1] + fibonacciSeries[n - 2];
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the steps for Fibonacci series: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Fibonacci fibonacci = new Fibonacci(limit, firstNumber, secondNumber);
        fibonacci.GenerateFibonacciSeries();
    }
}
