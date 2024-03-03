using System;
using System.Collections.Generic;

class Fibonacci
{
    private List<int> sequence = new List<int>();
    private int stepCount = 0;

    public List<int> Sequence => sequence;
    public int StepCount => stepCount;

    public void GenerateSequence(int limit, int first = 0, int second = 1)
    {
        if (sequence.Count == 0)
        {
            sequence.Add(first);
            if (first != second)
            {
                sequence.Add(second);
            }
        }

        int next = first + second;
        if (next > limit)
        {
            return;
        }
        sequence.Add(next);
        stepCount++;
        GenerateSequence(limit, second, next);
    }
}
