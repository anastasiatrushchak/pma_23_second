using System;
using System.Collections.Generic;
using System.IO;

namespace FibonacciProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = ReadNumbersFromFile("C:\\Users\\User\\RiderProjects\\Solution2\\ConsoleApp1\\bin\\Debug\\net8.0\\NewFile1.txt");
            
                Service service = new Service();
                Fibonacci fibonacciByMaxValue = service.CalculateFibonacciByMaxValue(inputNumbers);
                Console.WriteLine("Fibonacci Sequence by Max Value:");
                Console.WriteLine(string.Join(", ", fibonacciByMaxValue.Sequence));
                Console.WriteLine($"Number of Steps: {fibonacciByMaxValue.Steps}");
                Console.WriteLine();

                Fibonacci fibonacciBySteps = service.CalculateFibonacciBySteps(inputNumbers);
                Console.WriteLine("Fibonacci Sequence by Steps:");
                Console.WriteLine(string.Join(", ", fibonacciBySteps.Sequence));
                Console.WriteLine($"Number of Steps: {fibonacciBySteps.Steps}");
        }

        static List<int> ReadNumbersFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                List<int> numbers = new List<int>();
                foreach (string line in lines)
                {
                    numbers.Add(number);
                }
                return numbers;
            }
        }
    }

    public class Service
    {
        public Fibonacci CalculateFibonacciByMaxValue(List<int> inputNumbers)
        {
            if (inputNumbers.Count < 3)
            {
                return null;
            }

            List<int> sequence = new List<int>() { inputNumbers[0], inputNumbers[1] };
            int maxValue = inputNumbers[2];
            return CalculateFibonacciByMaxValueRecursive(sequence, maxValue);
        }

        private Fibonacci CalculateFibonacciByMaxValueRecursive(List<int> sequence, int maxValue)
        {
            int nextNum = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
            if (nextNum > maxValue)
            {
                return new Fibonacci(sequence, sequence.Count - 1);
            }
            sequence.Add(nextNum);
            return CalculateFibonacciByMaxValueRecursive(sequence, maxValue);
        }

        public Fibonacci CalculateFibonacciBySteps(List<int> inputNumbers)
        {
            if (inputNumbers.Count < 3)
            {
                return null;
            }

            List<int> sequence = new List<int>() { inputNumbers[0], inputNumbers[1] };
            int numSteps = inputNumbers[2];
            return CalculateFibonacciByStepsRecursive(sequence, numSteps);
        }

        private Fibonacci CalculateFibonacciByStepsRecursive(List<int> sequence, int numSteps)
        {
            if (sequence.Count >= numSteps)
            {
                return new Fibonacci(sequence, numSteps);
            }

            int nextNum = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
            sequence.Add(nextNum);
            return CalculateFibonacciByStepsRecursive(sequence, numSteps);
        }
    }

    public class Fibonacci
    {
        public List<int> Sequence { get; }
        public int Steps { get; }

        public Fibonacci(List<int> sequence, int steps)
        {
            Sequence = sequence;
            Steps = steps;
        }
    }
}

