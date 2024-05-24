using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace fibonacci
{
    class Creater
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\kravc\source\repos\Fibonacci\Fibonacci\info.txt";

            List<double> chysla_first = new List<double>();
            List<double> chysla_second = new List<double>();

            string[] read_line = File.ReadAllLines(file);


            string[] chysla= read_line[0].Split(' ');
            foreach (string element in chysla)
            {
                if (double.TryParse(element, out double chyslo))
                {
                    chysla_first.Add(chyslo);
                    chysla_second.Add(chyslo);
                }
            }


            int border = Convert.ToInt32(read_line[1]);


            int step = Convert.ToInt32(read_line[2]);

            Fibonacci run_border = Service.RunBorder(chysla_first, border);
            Console.WriteLine($"First:When border = {border}: {string.Join(", ", run_border.Array)}");
            Console.WriteLine($" First.2:Number of steps to border:{run_border.Steps}");

            List<double> run_step = Service.RunStep(chysla_second, step);
            Console.WriteLine($"Second:With countof steps = {step} fibonacci:{string.Join(",", run_step)}");
        }
    }
}
