using System.Collections.Generic;

namespace Fibonacci1
{
    sealed class Service
    {
        public static Fibonacci ToBorder(int border, List<double> sequence, int counter = 0)
        {
            double next = sequence[^1] + sequence[^2];
            if (border >= next)
            {
                sequence.Add(next);
                counter++;
                return ToBorder(border, sequence, counter);
            }
            return new Fibonacci(sequence, counter);
        }

        public static List<double> ToSteps(int steps, List<double> sequence)
        {
            if (steps > 0)
            {
                sequence.Add(sequence[^1] + sequence[^2]);
                ToSteps(steps - 1, sequence);
            }
            return sequence;
        }
    }
}