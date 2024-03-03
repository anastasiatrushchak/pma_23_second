using System.Collections.Generic;

namespace Lab_1_2
{
    public class Program
    {
        //First line - 2 numbers with space
        //Second line - Steeps
        //Third line - Limit
        //Steep or limit must be 0
        private static string filenameInput = "fibnum.txt";
        private static string filenameOutput = "fibresult.txt";
        public static void Main()
        {
            (List<double> fibnumbers, double limit, int? steeps) Service = ReadFile(filenameInput);
            (Service.fibnumbers, Service.steeps) = Fibonacci.CalculateFibonacci(Service.fibnumbers, Service.limit, (int)Service.steeps);
            Output(Service.fibnumbers, Service.steeps);
            WriteToFile(Service.fibnumbers, Service.steeps, filenameOutput);
        }
        private static (List<double>, double, int) Input()
        {
            List<double> numbers = new();
            double limit = 0;
            int steeps = 0;
            Console.Write("Input first number: ");
            numbers.Add(double.Parse(Console.ReadLine()!));
            Console.Write("Input second number: ");
            numbers.Add(double.Parse(Console.ReadLine()!));
            Console.Write("Input limit: ");
            limit = double.Parse(Console.ReadLine()!);
            Console.Write("Input steeps number: ");
            steeps = int.Parse(Console.ReadLine()!);
            return (numbers, limit, steeps);
        }
        private static void Output(List<double> list, double? steeps) 
        {
            foreach (double element in list)
            {
                Console.Write(element.ToString() + '\t');
            }
            if(steeps != null)
            {
                Console.WriteLine('\n' + steeps.ToString());
            }
        }
        private static (List<double>, double, int) ReadFile(string filename)
        {
            string input = "";
            int steeps = 0;
            double limit = 0;
            using (StreamReader file = new StreamReader(filename))
            {
                input = file.ReadLine()!;
                if(!file.EndOfStream)
                {
                    steeps = int.Parse(file.ReadLine()!);
                }
                if (!file.EndOfStream)
                {
                    limit = int.Parse(file.ReadLine()!);
                }
                
            }
            return (input.Split().Select(double.Parse).ToList(), limit, steeps);
        }
        private static void WriteToFile(List<double> list, double? count, string filename) 
        {
            using(StreamWriter file = new StreamWriter(filename))
            {
                foreach (double element in list)
                {
                    file.Write(element.ToString() + '\t');
                }
                file.WriteLine('\n' + count.ToString());
            }
        }
    }

    public static class Fibonacci
    {
        public static (List<double> fibonacci, int? count) CalculateFibonacci(List<double> numbers, double limit, int steeps)
        {
            if(steeps == 0)
            {
                return FibonacciLimit(numbers, limit);
            }
            else
            {
                return FibonacciSteep(numbers, steeps);
            }
        }
        private static (List<double>, int? count) FibonacciLimit(List<double> numbers, double limit)
        {
            if (numbers[^1] + numbers[^2] > limit)
            {
                return new(numbers, numbers.Count - 2);
            }
            else
            {
                numbers.Add(numbers[^1] + numbers[^2]);
                return FibonacciLimit(numbers, limit);
            }
        }
        private static (List<double>, int? count) FibonacciSteep(List<double> numbers, int steeps)
            {
                if (steeps == 0)
                {
                    return (numbers,null) ;
                }
                else
                {
                    numbers.Add(numbers[^1] + numbers[^2]);
                    steeps--;
                    return FibonacciSteep(numbers, steeps);
                }

            }
    }
}
