using System;
using System.Runtime.CompilerServices;

namespace FibonachiBorder
{
   
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] line;
            List<double> queue = new List<double>();
            int counter = 0;

            Console.WriteLine("Input border or steps: ");
            string method = Console.ReadLine();

            if (method == "border")
            {
                
                double border = 10;
                try
                {
                    StreamReader st = new StreamReader("C:\\Users\\Златомира\\source\\repos\\C#\\Fibonacci\\FibonachiBorder\\InputBorder.txt");
                    line = st.ReadLine().Split(" ");
                    border = int.Parse(line[0]);
                    queue = new List<double>() { int.Parse(line[1]), int.Parse(line[2]) };

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }


                Final result = Fibonachi.Border(border, queue, counter);

                Console.WriteLine(result);
            }
            else if (method == "steps")
            {
                int steps = 1;
                try
                {
                    StreamReader st = new StreamReader("C:\\Users\\Златомира\\source\\repos\\C#\\Fibonacci\\FibonachiBorder\\InputSteps.txt");
                    line = st.ReadLine().Split(" ");
                    steps = int.Parse(line[0]);
                    queue = new List<double>() { int.Parse(line[1]), int.Parse(line[2]) };

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

                List<double> result = Fibonachi.Steps(queue, steps);
                foreach (double step in result)
                {
                    Console.Write($"{step} ");
                }
                

            }
            else
            {
                Console.WriteLine("Please enter border or steps");
            }

            



        }
    }

}
