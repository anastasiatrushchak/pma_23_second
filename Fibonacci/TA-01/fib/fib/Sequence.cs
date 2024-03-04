using System;
using System.Collections.Generic;

public class Sequence
{
    private List<int> fibonacciList;
    private int steps;
    private int limit;

    public int Steps { get { return steps; } }

    public Sequence(int firstValue, int secondValue, int limit)
    {
        fibonacciList = new List<int> { firstValue, secondValue };
        this.limit = limit;
        steps = 0;
    }

    public List<int> GenerateFibonacci()
    {
        Service.GenerateFibonacci(fibonacciList, limit, ref steps);
        return fibonacciList;
    }

    public List<int> GenerateFibonacciWithLimit(int stepsLimit2)
    {
        Service.GenerateFibonacciWithLimit(fibonacciList, stepsLimit2, ref steps);
        return fibonacciList.ToList();
    }
}
