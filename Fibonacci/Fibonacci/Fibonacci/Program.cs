using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string inputFile = "input.txt";
            string[] lines = File.ReadAllLines(inputFile);

            if (lines.Length < 8)
            {
                Console.WriteLine("У файлі недостатньо даних.");
                return;
            }
            int first = int.Parse(lines[1].Trim());
            int second = int.Parse(lines[2].Trim());
            int limit = int.Parse(lines[3].Trim());
            int first1 = int.Parse(lines[5].Trim());
            int second1 = int.Parse(lines[6].Trim());
            int steps = int.Parse(lines[7].Trim());

            Fibonacci generator = new Fibonacci();
            generator.GenerateSequence(limit, first, second);

            Fibonacci2 Fibgenerator = new Fibonacci2();
            List<int> sequence1 = Fibgenerator.GenerateSequence1(first1, second1, steps);

            string result = $"Ряд Фібоначчі (починаючи з {first} та {second} до {limit}): " + string.Join(" ", generator.Sequence) + "\nКроків: " + generator.StepCount + $"\n\nРяд Фібоначчі ({steps} кроків, починаючи з {first1} та {second1}): {string.Join(" ", sequence1)}";

            string outputFilePath = "result.txt";
            File.WriteAllText(outputFilePath, result);

            Console.WriteLine($"Результат було записано у файл: {outputFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виникла помилка: {ex.Message}");
        }
    }
}
