using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Виберіть тип алгоритму:");
            Console.WriteLine("1. Алгоритм Фібоначчі (Границя)");
            Console.WriteLine("2. Алгоритм Фібоначчі (Кроки)");

            int selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                Console.WriteLine("Введіть границю:");
                int limit = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть шлях до текстового файлу, де знаходяться початкові числа (наприклад, start.txt):");
                string filePath = Console.ReadLine();

                string[] startNumbers = File.ReadAllLines(filePath);
                int firstNumber = int.Parse(startNumbers[0]);
                int secondNumber = int.Parse(startNumbers[1]);

                FibonacciWithLimit fibWithLimit = new FibonacciWithLimit();
                fibWithLimit.Run(limit, firstNumber, secondNumber);
            }
            else if (selection == 2)
            {
                Console.WriteLine("Введіть кількість кроків:");
                int steps = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть шлях до текстового файлу, де знаходяться початкові числа (наприклад, start.txt):");
                string filePath = Console.ReadLine();

                string[] startNumbers = File.ReadAllLines(filePath);
                int firstNumber = int.Parse(startNumbers[0]);
                int secondNumber = int.Parse(startNumbers[1]);

                FibonacciWithSteps fibWithSteps = new FibonacciWithSteps();
                fibWithSteps.Run(steps, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Неправильний вибір.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    class FibonacciBase
    {
        protected void DisplayResult(int[] sequence, int steps)
        {
            Console.WriteLine($"Послідовність: {string.Join(" ", sequence)}");
            Console.WriteLine($"Кількість кроків: {steps}");
        }
    }

    class FibonacciWithLimit : FibonacciBase
    {
        public void Run(int limit, int firstNumber, int secondNumber)
        {
            try
            {
                int[] sequence;
                int steps;

                CalculateFibonacciWithLimit(limit, firstNumber, secondNumber, out sequence, out steps);

                DisplayResult(sequence, steps);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void CalculateFibonacciWithLimit(int limit, int firstNumber, int secondNumber, out int[] sequence, out int steps)
        {
            FibonacciCalculator calculator = new FibonacciCalculator(firstNumber, secondNumber);
            sequence = calculator.GenerateSequenceWithLimit(limit, out steps);
        }
    }

    class FibonacciWithSteps : FibonacciBase
    {
        public void Run(int steps, int firstNumber, int secondNumber)
        {
            try
            {
                int[] sequence;

                CalculateFibonacciWithSteps(steps, firstNumber, secondNumber, out sequence);

                DisplayResult(sequence, steps);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void CalculateFibonacciWithSteps(int steps, int firstNumber, int secondNumber, out int[] sequence)
        {
            FibonacciCalculator calculator = new FibonacciCalculator(firstNumber, secondNumber);
            sequence = calculator.GenerateSequenceWithSteps(steps);
        }
    }

    class FibonacciCalculator
    {
        private int firstNumber;
        private int secondNumber;

        public FibonacciCalculator(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int[] GenerateSequenceWithLimit(int limit, out int steps)
        {
            int[] sequence = GenerateSequence(limit, out steps);
            return sequence;
        }

        public int[] GenerateSequenceWithSteps(int steps)
        {
            int[] sequence = GenerateSequence(steps);
            return sequence;
        }

        private int[] GenerateSequence(int limit, out int steps)
        {
            int[] sequence = new int[limit];
            steps = 0;

            for (int i = 0; i < limit; i++)
            {
                sequence[i] = GenerateNextFibonacci();
                steps++;

                if (sequence[i] > limit)
                    break;
            }

            return sequence;
        }

        private int[] GenerateSequence(int steps)
        {
            int[] sequence = new int[steps];

            for (int i = 0; i < steps; i++)
            {
                sequence[i] = GenerateNextFibonacci();
            }

            return sequence;
        }

        private int GenerateNextFibonacci()
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp + secondNumber;
            return firstNumber;
        }
    }
}
