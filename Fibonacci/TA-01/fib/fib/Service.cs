using System.Collections.Generic;
using System.Linq;

public static class Service
{
    public static List<int> GenerateFibonacci(List<int> fibonacciList, int limit, ref int steps)
    {
        while (fibonacciList.Count < 3 || (fibonacciList.Count < limit + 2 && fibonacciList[fibonacciList.Count - 1] + fibonacciList[fibonacciList.Count - 2] <= limit))
        {
            int nextValue = fibonacciList[fibonacciList.Count - 1] + fibonacciList[fibonacciList.Count - 2];
            fibonacciList.Add(nextValue);
            steps++;
        }

        return fibonacciList;
    }

    public static List<int> GenerateFibonacciWithLimit(List<int> fibonacciList, int stepsLimit2, ref int steps)
    {
        int initialSteps = steps;

        while (steps - initialSteps < stepsLimit2)
        {
            int nextValue = fibonacciList[fibonacciList.Count - 1] + fibonacciList[fibonacciList.Count - 2];
            fibonacciList.Add(nextValue);
            steps++;
        }

        return fibonacciList.ToList();
    }
}
