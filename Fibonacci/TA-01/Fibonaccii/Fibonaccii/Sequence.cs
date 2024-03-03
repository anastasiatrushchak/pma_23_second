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
       
        while (fibonacciList.Count < 3 || (fibonacciList.Count < limit + 2 && fibonacciList[fibonacciList.Count - 1] + fibonacciList[fibonacciList.Count - 2] <= limit))
        {
            int nextValue = fibonacciList[fibonacciList.Count - 1] + fibonacciList[fibonacciList.Count - 2];
            fibonacciList.Add(nextValue);
            steps++;
        }

        return fibonacciList;
    }

   
   public List<int> GenerateFibonacciWithLimit(int stepsLimit2)
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
