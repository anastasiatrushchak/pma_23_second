namespace Fibonacci_algorithm;

public class Sequence
{
    public List<double> numbers;

    public int Steps
    {
        get => numbers.Count-2;
        
    }

    public Sequence(double first, double second)
    {
        numbers = new List<double>();
        numbers.Add(first);
        numbers.Add(second);

    }
}