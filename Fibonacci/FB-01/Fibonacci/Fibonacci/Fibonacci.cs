using System.Collections.Generic;

namespace fibonachi
{
    public class Fibonacci
    {
        public List<double> Arr { get; set; }
        public int Step { get; set; }
        public Fibonacci(List<double> arr, int step)
        {
            Arr = arr;
            Step = step;
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", Arr)}], Steps: {Step}";
        }



    }
}


        

