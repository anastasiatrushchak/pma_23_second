using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    sealed class Service
    {
        public static Fibonacci RunBorder(List<double> arr, int border, int count = 0)
        {
            if ((arr[arr.Count - 1] + arr[arr.Count - 2]) <= border)
            {
                count++;
                arr.Add(arr[arr.Count - 1] + arr[arr.Count - 2]);
                return RunBorder(arr, border, count);
            }
            return new Fibonacci(arr, count);

        }

        public static List<double> RunStep(List<double> arr, int step)
        {
            if (step != 0)
            {
                step--;
                arr.Add(arr[arr.Count - 1] + arr[arr.Count - 2]);
                return RunStep(arr, step);
            }
            else
            {
                return arr;
            }
        }
    }
}