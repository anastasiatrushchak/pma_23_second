using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_task1
{
    public class Final
    {
        private List<double> queue;
        private int counter;

        public Final(List<double> queue, int counter)
        {
            this.queue = queue;
            this.counter = counter;
        }
        public override string ToString() 
        {
            string res = string.Join<double>(" ", queue);
            return $"numbers: {res}\nsteps: {counter}";
        }
    }
}
