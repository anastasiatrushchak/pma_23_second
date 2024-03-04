using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fibonacci_task1
{
   
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            string[] lines = File.ReadAllLines("task1.txt");
            double a = double.Parse(lines[0]);
            double b = double.Parse(lines[1]);
            double border = double.Parse(lines[2]);
            List<double> queue = new List<double>();
            queue.Add(a);
            queue.Add(b);
            Final f = Fibonacci.Border(border, queue, 0);
            Console.WriteLine($"border: {border}");
            Console.WriteLine(f.ToString() + "\n");

            Console.WriteLine("task 2");
            string[] info = File.ReadAllLines("task2.txt");
            double first = double.Parse(info[0]);
            double second = double.Parse(info[1]);
            int steps = int.Parse(info[2]);
            List<double> result = new List<double>();
            result.Add(a);
            result.Add(b);
            Final res = Fibonacci.Steps(steps, result, 0);
            Console.WriteLine(res);
        }
    }

}
