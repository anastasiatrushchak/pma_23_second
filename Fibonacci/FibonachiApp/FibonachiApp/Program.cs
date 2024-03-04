using System;
using System.Collections.Generic;
using System.IO;

namespace Fibonacci
{
    public class Fibonacci
    {
        public List<double> Arr { get; set; }
        public int Step { get; set; }

        public Fibonacci(List<double> arr, int step)
        {
            Arr = arr;
            Step = step;
        }

        public override string ToString()
        {
            return $"The first task: [{string.Join(", ", Arr)}], Steps: {Step}";
        }
    }

    sealed class Service
    {
        public static Fibonacci RunLimit(List<double> arr, int limit, int count = 0)
        {
            if ((arr[arr.Count - 1] + arr[arr.Count - 2]) <= limit)
            {
                count++;
                arr.Add(arr[arr.Count - 1] + arr[arr.Count - 2]);
                return RunLimit(arr, limit, count);
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

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Admin\Desktop\UnivercityProject\FibonachiApp\FibonachiApp\input.txt";
            List<double> numbers1 = new List<double>();
            List<double> numbers2 = new List<double>();

            string line = File.ReadAllText(filePath);
            string[] parts = line.Split(' ');
            foreach (string part in parts)
            {
                if (double.TryParse(part, out double number))
                {
                    numbers1.Add(number);
                    numbers2.Add(number);
                }
            }

            int limit = 400;
            Fibonacci rez_limit = Service.RunLimit(numbers1, limit);
            Console.WriteLine(rez_limit);

            int step = 8;
            List<double> rez_step = Service.RunStep(numbers2, step);
            Console.WriteLine("The second program: " + string.Join(", ", rez_step));
        }
    }
}

