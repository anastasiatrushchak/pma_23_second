using System;
using System.Collections.Generic;

class Fibonacci2
{
    public List<int> GenerateSequence1(int first1, int second1, int steps)
    {
        List<int> sequence1 = new List<int>();
        if (steps > 0)
        {
            sequence1.Add(first1);
            sequence1.AddRange(GenerateSequenceRecursive(steps, first1, second1));
        }
        return sequence1;
    }

    private List<int> GenerateSequenceRecursive(int remainingSteps, int first1, int second1)
    {
        List<int> sequence1 = new List<int>();
        if (remainingSteps == -1)
        {
            return sequence1;
        }
        sequence1.Add(second1);
        int next = first1 + second1;
        sequence1.AddRange(GenerateSequenceRecursive(remainingSteps - 1, second1, next));
        return sequence1;
    }
}
