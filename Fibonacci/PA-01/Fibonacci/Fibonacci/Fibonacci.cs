using System.Collections.Generic;

namespace Fibonacci1
{
    class Fibonacci
    {
        public List<double> Sequence { get;  set; }
        public int Steps { get;  set; }

        public Fibonacci(List<double> sequence, int steps)
        {
            Sequence = sequence;
            Steps = steps;
        }

        
    }
}