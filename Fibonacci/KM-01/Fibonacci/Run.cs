using System;
using System.Collections.Generic;
using System.IO;

namespace fibonacci
{
    class Creater
    {
        static void Main(string[] args)
        {
            
            string filePath = @"C:\Users\kravc\source\repos\Fibonacci\Fibonacci\info.txt";

           
            List<double> chysla = ReadValuesFromFile(filePath, "chysla");
            double border = ReadDoubleFromFile(filePath, "border");
            int steps = ReadIntFromFile(filePath, "steps");

            
            Fibonacci my_border = Service.RunBorder(chysla, border, 0, 1000);
            Console.WriteLine(my_border);

            List<double> chysla2 = new List<double> { 0, 1 };
            List<double> my_numbers = Service.RunStep(chysla2, steps);
            Console.WriteLine(string.Join(",", my_numbers));
        }

        
        static List<double> ReadValuesFromFile(string filePath, string key)
        {
            List<double> values = new List<double>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2 && parts[0].Trim().ToLower() == key.ToLower())
                    {
                        string[] numbers = parts[1].Split(',');
                        foreach (string num in numbers)
                        {
                            if (double.TryParse(num.Trim(), out double value))
                            {
                                values.Add(value);
                            }
                        }
                        break; 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading values for {key}: {ex.Message}");
            }

            return values;
        }

     
        static double ReadDoubleFromFile(string filePath, string key)
        {
            double value = 0;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2 && parts[0].Trim().ToLower() == key.ToLower())
                    {
                        if (double.TryParse(parts[1].Trim(), out value))
                        {
                            break; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading value for {key}: {ex.Message}");
            }

            return value;
        }
        static int ReadIntFromFile(string filePath, string key)
        {
            int value = 0;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2 && parts[0].Trim().ToLower() == key.ToLower())
                    {
                        if (int.TryParse(parts[1].Trim(), out value))
                        {
                            break; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading value for {key}: {ex.Message}");
            }

            return value;
        }
    }
}
