namespace Fibonacci_algorithm;

public class Service
{
    public static Sequence CalculateSequenceBySteps(Sequence sequence, int steps)
    {
        if (steps == 0)
        {
            return sequence;
        }
        sequence.numbers.Add(sequence.numbers[sequence.numbers.Count -1] + sequence.numbers[sequence.numbers.Count -2]);
        return CalculateSequenceBySteps(sequence, steps-1);
    }
    public static Sequence CalculateSequenceByLimit(Sequence sequence, double limit)
    {
        if (sequence.numbers[sequence.numbers.Count -1] + sequence.numbers[sequence.numbers.Count -2] > limit)
        {
            return sequence;
        }
        sequence.numbers.Add(sequence.numbers[sequence.numbers.Count -1] + sequence.numbers[sequence.numbers.Count -2]);
        return CalculateSequenceByLimit(sequence, limit);
    }
}