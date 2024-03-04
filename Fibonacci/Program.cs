using System;
using System.IO;
namespace Fibonacci

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            int first = int.Parse(lines[0]);
            int second = int.Parse(lines[1]);
            int limit = int.Parse(lines[2]);

            FibonacciSequence fibonacci = new FibonacciSequence();
            Service.GenerateByLimit(fibonacci, limit, first, second);
            Console.WriteLine("Ряд: " + string.Join(" ", fibonacci.Sequence));
            Console.WriteLine("Крокiв: " + fibonacci.Steps);

            fibonacci = new FibonacciSequence();
            int steps = int.Parse(lines[3]);
            Service.GenerateBySteps(fibonacci, steps, first, second);
            Console.WriteLine("Ряд: " + string.Join(" ", fibonacci.Sequence));
            Console.WriteLine("Крокiв: " + fibonacci.Steps);
        }
    }
}