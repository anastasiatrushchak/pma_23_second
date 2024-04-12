using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class FibonacciSequence
    {
        public List<int> series;

        public FibonacciSequence(int firstNumber, int secondNumber, int upperLimit, int lowerLimit, int stepsLimit)
        {
            series = new List<int>();
            series.Add(firstNumber);
            series.Add(secondNumber);
            GenerateSeries(firstNumber, secondNumber, upperLimit, lowerLimit, stepsLimit);
        }

        public void GenerateSeries(int firstNumber, int secondNumber, int upperLimit, int lowerLimit, int stepsLimit)
        {
            int steps = 2; // Початкова кількість кроків
            while (steps < stepsLimit)
            {
                int nextNumber = firstNumber + secondNumber;
                if (nextNumber > upperLimit || nextNumber < lowerLimit)
                    break;
                series.Add(nextNumber);
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                steps++;
            }
        }

        public void PrintSeries()
        {
            Console.WriteLine("Ряд Фiбоначчi:");
            foreach (int num in series)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public int GetSteps()
        {
            return series.Count; // Кількість кроків дорівнює кількості чисел у ряді
        }
    }

    class Task1
    {
        static void Main()
        {
            Console.WriteLine("Таск 1: Введiть перше число для ряду Фiбоначчi:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Таск 1: Введiть друге число для ряду Фiбоначчi:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Таск 1: Введiть верхню межу лiмiту:");
            int upperLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Таск 1: Введiть нижню межу лiмiту:");
            int lowerLimit = int.Parse(Console.ReadLine());

            FibonacciSequence sequence1 = new FibonacciSequence(firstNumber, secondNumber, upperLimit, lowerLimit, int.MaxValue);

            sequence1.PrintSeries();
            Console.WriteLine($"Таск 1: Кiлькiсть крокiв: {sequence1.GetSteps()}");

            // Задати межі для другого таску у програмі
            int secondUpperLimit = 1000;

            Console.WriteLine("\nТаск 2: Введiть перше число для ряду Фiбоначчi:");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Таск 2: Введiть друге число для ряду Фiбоначчi:");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Таск 2: Введiть кiлькiсть крокiв:");
            int stepsLimit = int.Parse(Console.ReadLine());

            FibonacciSequence sequence2 = new FibonacciSequence(firstNumber, secondNumber, secondUpperLimit, lowerLimit, stepsLimit);
            sequence2.PrintSeries();
            Console.WriteLine($"Таск 2: Кiлькiсть крокiв: {sequence2.GetSteps()}");
        }
    }
}
