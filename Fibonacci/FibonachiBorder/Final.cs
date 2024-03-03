using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiBorder
{
    class Final
    {
        private List<double> sequence;
        private int counter;
        public Final(List<double> sequence, int counter)
        {
            this.sequence = sequence;
            this.counter = counter;

        }

        public override string ToString()
        {
            return $"Sequence: {string.Join(" ", sequence)}, Steps: {counter}";
        }
    }
}
