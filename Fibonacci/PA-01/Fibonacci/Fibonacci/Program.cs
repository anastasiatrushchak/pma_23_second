using System;
using System.Collections.Generic;
using System.IO;

namespace Fibonacci1
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"D:\C#\Programming\Fibonacci\Fibonacci\input.txt";
            string[] lines = File.ReadAllLines(filePath);
           
            double firstNumber = double.Parse(lines[0]);
            double secondNumber = double.Parse(lines[1]);
            
            int border = int.Parse(lines[2]);
            int steps = int.Parse(lines[3]);

            List<double> sequence1 = new List<double> { firstNumber, secondNumber };

            Fibonacci fibToBorder = Service.ToBorder(border, sequence1);
            Console.WriteLine($"First task: Fibonacci to {border}: {string.Join(", ", fibToBorder.Sequence)}");
            Console.WriteLine($"First task: Number of Steps: {fibToBorder.Steps}");

            
            List<double>  sequence2 = new List<double> { firstNumber, secondNumber }; 
            List<double> fibToSteps = Service.ToSteps(steps, sequence2);
            Console.WriteLine($"Second task: Fibonacci for {steps}  steps: {string.Join(", ", fibToSteps)}");
        }
    }
}