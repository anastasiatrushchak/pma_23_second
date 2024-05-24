using System.Collections.Generic;
namespace fibonacci;

public class Fibonacci
{
    private List<double> array { get; set; }
    private int steps { get; set; }
    public Fibonacci(List<double> array, int steps)
    {
        Array = array;
        Steps = steps;
    }
    public List<double> Array { get => array; private set => array = value; }
    public int Steps { get => steps; set => steps = value; }

    public override string ToString()
    {
        return $"Steps:{steps}, Fibonacci: {string.Join(",", array)}";

    }
}