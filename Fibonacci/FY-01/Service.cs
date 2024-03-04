

namespace Fibonacci
{
    static class Service
    {
        public static void GenerateByLimit(FibonacciSequence fibonacci, int limit, int first = 0, int second = 1)
        {
            if (first > limit)
                return;

            fibonacci.Sequence.Add(first);

            if (fibonacci.Sequence.Count > 2)
                fibonacci.Steps++;

            GenerateByLimit(fibonacci, limit, second, first + second);
        }

        public static void GenerateBySteps(FibonacciSequence fibonacci, int steps, int first = 0, int second = 1)
        {
            if (fibonacci.Steps >= steps)
                return;

            fibonacci.Sequence.Add(first);

            if (fibonacci.Sequence.Count > 2)
                fibonacci.Steps++;

            GenerateBySteps(fibonacci, steps, second, first + second);
        }
    }
}
