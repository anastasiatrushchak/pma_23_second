using System;
using System.Collections.Generic;
using System.IO;

public class FibonacciService
{
    public class Fibonacci
    {
        private List<int> list;
        private int step;

        public Fibonacci(List<int> list, int step)
        {
            this.list = list;
            this.step = step;
        }

        public List<int> GetList()
        {
            return list;
        }

        public int GetStep()
        {
            return step;
        }
    }

    public Fibonacci FibonacciList(List<int> numbers)
    {
        return new Fibonacci(numbers, 0);
    }

    public static void Main(string[] args)
    {
        FibonacciService fibonacciService = new FibonacciService();

        string filePath = @"C:\c++\modul 1\8(3)\fibnum.txt";
        string[] lines = File.ReadAllLines(filePath);
        List<int> numbers = new List<int> { int.Parse(lines[0]), int.Parse(lines[1]) };
        int limit = int.Parse(lines[2]);
        int stepsToGenerate = int.Parse(lines[3]);

        FibonacciService.Fibonacci fibonacci = fibonacciService.FibonacciList(numbers);
        DisplayFibonacciState(fibonacci);
        FibonacciService.Fibonacci result = FibonacciBorder(fibonacci, limit);
        DisplayFibonacciState(result, limit);
        result = GetFibonacciByStepsLimit(fibonacci, stepsToGenerate);
        DisplayFibonacciSteps(result);
    }

    private static Fibonacci FibonacciBorder(Fibonacci fibonacci, int limit)
    {
        return FibonacciBorderRecursive(fibonacci, limit, 0);
    }

    private static Fibonacci FibonacciBorderRecursive(Fibonacci fibonacci, int limit, int step)
    {
        List<int> list = fibonacci.GetList();
        int newElement = list[^2] + list[^1];
        if (newElement < limit)
        {
            list.Add(newElement);
            step++;
            return FibonacciBorderRecursive(fibonacci, limit, step);
        }
        return new Fibonacci(list, step);
    }

    public static Fibonacci GetFibonacciByStepsLimit(Fibonacci fibonacci, int stepsToGenerate)
    {
        return FibonacciSteps(fibonacci, stepsToGenerate);
    }

    private static Fibonacci FibonacciSteps(Fibonacci fibonacci, int stepsToGenerate)
    {
        return FibonacciStepsRecursive(fibonacci, stepsToGenerate);
    }

    private static Fibonacci FibonacciStepsRecursive(Fibonacci fibonacci, int stepsToGenerate)
    {
        if (stepsToGenerate <= 0)
            return fibonacci;

        List<int> list = fibonacci.GetList();
        int newElement = list[^2] + list[^1];
        list.Add(newElement);

        return FibonacciStepsRecursive(new Fibonacci(list, fibonacci.GetStep() + 1), stepsToGenerate - 1);
    }

    static void DisplayFibonacciState(Fibonacci fibonacci)
    {
        Console.WriteLine($"first 2 numbers: {string.Join(", ", fibonacci.GetList())}");
        Console.WriteLine();
    }

    static void DisplayFibonacciState(Fibonacci fibonacci, int limit)
    {
        Console.WriteLine($"fibonacci: {string.Join(", ", fibonacci.GetList())}");
        Console.WriteLine($"border: {limit}");
        Console.WriteLine($"steps: {fibonacci.GetStep()}");
        Console.WriteLine();
    }

    static void DisplayFibonacciSteps(Fibonacci fibonacci)
    {
        Console.WriteLine($"fibonacci: {string.Join(", ", fibonacci.GetList())}");
        Console.WriteLine($"steps: {fibonacci.GetStep()}");
        Console.WriteLine();
    }
}
