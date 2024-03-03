using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace fibonacci
{
    class Service
    {
        public static Fibonacci RunBorder(List<double> array, double border, int count, int maxSteps)
        {
            if (count < maxSteps && (array[array.Count - 1] + array[array.Count - 2]) <= border)
            {
                count++;
                array.Add(array[array.Count - 1] + array[array.Count - 2]);
                return RunBorder(array, border, count, maxSteps);
            }
            return Fibonacci.Generate(array, count);
        }

        public static List<double>RunStep(List<double>array,int steps)
        {
            if (steps != 0)
            {
                steps--;
                array.Add(array[array.Count-1]+array[array.Count-2]);
                return RunStep(array,steps);
            }
            else
            {
                return array;   
            }
        }
    }
}