using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalSubtraction
{
    class Operations
    {
        public static void Additional(List<List<double>> first_matrix, List<List<double>> second_matrix)
        {
            if (!(first_matrix.Count == second_matrix.Count && first_matrix[0].Count == second_matrix[0].Count))
            {
                Console.WriteLine("Matrices are not of the same dimension");
            }
            else
            {
                int rows = first_matrix.Count;
                int columns = first_matrix[0].Count;

                List<List<double>> result = new List<List<double>>();
                for (int i = 0; i < rows; i++)
                {
                    List<double> row = new List<double>();
                    for (int j = 0; j < columns; j++)
                    {
                        row.Add(first_matrix[i][j] + second_matrix[i][j]);
                    }
                    result.Add(row);
                }
                
                Operations.Print(result);
            }
        }

        public static void Subtraction(List<List<double>> first_matrix, List<List<double>> second_matrix)
        {
            if (!(first_matrix.Count == second_matrix.Count && first_matrix[0].Count == second_matrix[0].Count))
            {
                Console.WriteLine("Matrices are not of the same dimension");
            }
            else
            {
                int rows = first_matrix.Count;
                int columns = first_matrix[0].Count;

                List<List<double>> result = new List<List<double>>();
                for (int i = 0; i < rows; i++)
                {
                    List<double> row = new List<double>();
                    for (int j = 0; j < columns; j++)
                    {
                        row.Add(first_matrix[i][j] - second_matrix[i][j]);
                    }
                    result.Add(row);
                }

                Operations.Print(result);
            }
        }

        public static List<List<double>> Read(string path)
        {
            try
            {
                List<List<double>> matrix = new List<List<double>>();
                string[] lines = System.IO.File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    List<double> row = line.Split(' ').Select(double.Parse).ToList();
                    matrix.Add(row);
                }

                return matrix;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }
        }

        public static void Print(List<List<double>> matrix)
        {
            if (matrix == null)
            {
                Console.WriteLine("Matrix is null.");
                return;
            }
            foreach (List<double> row in matrix)
            {
                foreach (double element in row)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
        }
    }


}
