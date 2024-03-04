namespace Fibonacci

{
    public class FibonacciSequence
    {
        public List<int> Sequence { get; set; }
        public int Steps { get; set; }

        public FibonacciSequence()
        {
            Sequence = new List<int>();
            Steps = 0;
        }
    }
}