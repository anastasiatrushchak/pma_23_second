using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        CalcToBorder("D:\\універ!\\sharping\\fib\\fib\\Input.txt");
    }

    public static void CalcToBorder(string filePath)
    {
        string[] lines = System.IO.File.ReadAllLines(filePath);

        int firstValue = int.Parse(lines[0]);
        int secondValue = int.Parse(lines[1]);
        int border1 = int.Parse(lines[2]);

        Sequence sequence1 = new Sequence(firstValue, secondValue, border1);
        List<int> result1 = sequence1.GenerateFibonacci();
        Console.WriteLine("Fibonacci sequence (Algorithm 1):");
        PrintSequence(result1);
        Console.WriteLine($"Number of steps (Algorithm 1): {sequence1.Steps}");

        int startValue1 = int.Parse(lines[3]);
        int startValue2 = int.Parse(lines[4]);
        int stepsLimit2 = int.Parse(lines[5]);

        Sequence sequence2 = new Sequence(startValue1, startValue2, stepsLimit2);
        List<int> result2 = sequence2.GenerateFibonacciWithLimit(stepsLimit2);
        Console.WriteLine("\nFibonacci sequence (Algorithm 2):");
        PrintSequence(result2);
        Console.WriteLine($"Number of steps (Algorithm 2): {stepsLimit2}");
    }

    private static void PrintSequence(List<int> sequence)
    {
        foreach (var num in sequence)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
