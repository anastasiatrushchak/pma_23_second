using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_task1
{
    public class Fibonacci
    {
        public static Final Border(double border, List<double> queue, int counter)
        {
            double next = queue[queue.Count - 1] + queue[queue.Count - 2];
            if (border > next)
            {
                counter++;
                queue.Add(next);
                return Border(border, queue, counter);
            }
            return new Final(queue, counter);
        }

        public static Final Steps(int steps, List<double> queue, int counter)
        {
            double next = queue[queue.Count - 1] + queue[queue.Count - 2];
            if (steps > counter) 
            {
                queue.Add(next);
                return Steps(steps, queue, counter + 1);
            }
            return new Final(queue, counter);
        }

    }
}
