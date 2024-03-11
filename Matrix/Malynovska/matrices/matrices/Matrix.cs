using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    public class Matrix
    {
        public Matrix() { }
        public static List<List<double>> ReadMatrix(string file_name)
        {
            List<List<double>> matrix = new List<List<double>>();
            try
            {
                using (StreamReader reader = new StreamReader(file_name))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] row = line.Split(' ');
                        List<double> list = new List<double>();
                        foreach (string s in row)
                        {
                            list.Add(double.Parse(s));
                        }
                        matrix.Add(list);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return matrix;
        }

        public static List<List<double>> AddMatrices(List<List<double>> matrix1, List<List<double>> matrix2)
        {
            List<List<double>> matrix = new List<List<double>>();

            if (matrix1.Count == matrix2.Count && matrix1[0].Count == matrix2[0].Count)
            {
                for (int i = 0; i < matrix1.Count; i++)
                {
                    List<double> rows = new List<double>();
                    for (int j = 0; j < matrix1[0].Count; j++)
                    {
                        rows.Add(matrix1[i][j] + matrix2[i][j]);
                    }
                    matrix.Add(rows);
                }
            }
            else
            {
                Console.WriteLine("Matrices should have equal size!");
            }
            return matrix;
        }

        public static List<List<double>> SubtractMatrices(List<List<double>> matrix1, List<List<double>> matrix2)
        {
            List<List<double>> matrix = new List<List<double>>();

            if (matrix1.Count == matrix2.Count && matrix1[0].Count == matrix2[0].Count)
            {
                for (int i = 0; i < matrix1.Count; i++)
                {
                    List<double> rows = new List<double>();
                    for (int j = 0; j < matrix1[0].Count; j++)
                    {
                        rows.Add(matrix1[i][j] - matrix2[i][j]);
                    }
                    matrix.Add(rows);
                }
            }
            else
            {
                Console.WriteLine("Matrices should have equal size!");
            }
            return matrix;
        }

        public static List<List<double>> MultiplyMatrices(List<List<double>> matrix1, List<List<double>> matrix2)
        {
            List<List<double>> result = new List<List<double>>();

            try
            {
                if (matrix1[0].Count != matrix2.Count)
                {
                    Console.WriteLine("Number of columns in the first matrix should be equal to the number of rows in the second matrix.");
                    return result;
                }

                for (int i = 0; i < matrix1.Count; i++)
                {
                    List<double> row = new List<double>();
                    for (int j = 0; j < matrix2[0].Count; j++)
                    {
                        double sum = 0;
                        for (int k = 0; k < matrix1[0].Count; k++)
                        {
                            sum += matrix1[i][k] * matrix2[k][j];
                        }
                        row.Add(sum);
                    }
                    result.Add(row);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }


        public static void PrintMatrix(List<List<double>> matrix)
        {
            for (int i = 0; i < matrix.Count;i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
