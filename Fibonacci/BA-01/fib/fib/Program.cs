using System;

class Fibonacci
{
    static void Main()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Оберіть тип алгоритму:");
            Console.WriteLine("1. Алгоритм Фібоначі (Границя)");
            Console.WriteLine("2. Алгоритм Фібоначі (Кроки)");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введіть межу:");
                int boundary = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть перше стартове число:");
                int start1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть друге стартове число:");
                int start2 = int.Parse(Console.ReadLine());

                FibonacciWithBoundary fibWithBoundary = new FibonacciWithBoundary();
                fibWithBoundary.Execute(boundary, start1, start2);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введіть кількість кроків:");
                int steps = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть перше стартове число:");
                int start1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть друге стартове число:");
                int start2 = int.Parse(Console.ReadLine());

                FibonacciWithSteps fibWithSteps = new FibonacciWithSteps();
                fibWithSteps.Execute(steps, start1, start2);
            }
            else
            {
                Console.WriteLine("Невірний вибір.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    class FibonacciBase
    {
        protected void WriteResult(int[] sequence, int steps)
        {
            Console.WriteLine($"Ряд: {string.Join(" ", sequence)}");
            Console.WriteLine($"Кроків: {steps}");
        }
    }

    class FibonacciWithBoundary : FibonacciBase
    {
        public void Execute(int boundary, int start1, int start2)
        {
            try
            {
                int[] sequence;
                int steps;

                CalculateFibonacciWithBoundary(boundary, start1, start2, out sequence, out steps);

                WriteResult(sequence, steps);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void CalculateFibonacciWithBoundary(int boundary, int start1, int start2, out int[] sequence, out int steps)
        {
            FibonacciCalculator calculator = new FibonacciCalculator(start1, start2);
            sequence = calculator.GenerateSequenceWithBoundary(boundary, out steps);
        }
    }

    class FibonacciWithSteps : FibonacciBase
    {
        public void Execute(int steps, int start1, int start2)
        {
            try
            {
                int[] sequence;

                CalculateFibonacciWithSteps(steps, start1, start2, out sequence);

                WriteResult(sequence, steps);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void CalculateFibonacciWithSteps(int steps, int start1, int start2, out int[] sequence)
        {
            FibonacciCalculator calculator = new FibonacciCalculator(start1, start2);
            sequence = calculator.GenerateSequenceWithSteps(steps);
        }
    }

    class FibonacciCalculator
    {
        private int start1;
        private int start2;

        public FibonacciCalculator(int start1, int start2)
        {
            this.start1 = start1;
            this.start2 = start2;
        }

        public int[] GenerateSequenceWithBoundary(int boundary, out int steps)
        {
            int[] sequence = GenerateSequence(boundary, out steps);
            return sequence;
        }

        public int[] GenerateSequenceWithSteps(int steps)
        {
            int[] sequence = GenerateSequence(steps);
            return sequence;
        }

        private int[] GenerateSequence(int boundary, out int steps)
        {
            int[] sequence = new int[boundary];
            steps = 0;

            for (int i = 0; i < boundary; i++)
            {
                sequence[i] = GenerateNextFibonacci();
                steps++;

                if (sequence[i] > boundary)
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
            int temp = start1;
            start1 = start2;
            start2 = temp + start2;
            return start1;
        }
    }
}
