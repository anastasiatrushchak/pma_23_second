using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace fibonacci;

static class Service
{
    
     public static Fibonacci RunBorder(List<double> array, int border, int count = 0)
     {
            if ((array[array.Count - 1] + array[array.Count - 2]) <= border)
            {
                count++;
                array.Add(array[array.Count - 1] + array[array.Count - 2]);
                return RunBorder(array, border, count);
            }
            return new Fibonacci(array, count);
        }

     public static List<double> RunStep(List<double> array, int steps)
     {
            if (steps != 0)
            {
                steps--;
                array.Add(array[array.Count - 1] + array[array.Count - 2]);
                return RunStep(array, steps);
            }
            else
            {
                return array;
            }
     }
    
}
