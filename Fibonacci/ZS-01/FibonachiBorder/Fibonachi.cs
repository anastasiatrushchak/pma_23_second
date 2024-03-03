using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiBorder
{
    class Fibonachi
    {
        public Fibonachi() { }
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

        public static List<double> Steps(List<double> queue, int steps, int counter = 0)
        {
            double next = queue[queue.Count - 1] + queue[queue.Count - 2];
            if (steps >= counter)
            {
                counter++;
                queue.Add(next);
                return Steps(queue, steps, counter);
            }
            return queue;
        }
    }
}
