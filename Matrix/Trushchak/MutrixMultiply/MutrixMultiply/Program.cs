using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            
            List<List<int>> matrixA = ReadMatrixFromFile("D:\\універ!\\sharping\\MutrixMultiply\\MutrixMultiply\\matrix_first.txt");
            List<List<int>> matrixB = ReadMatrixFromFile("D:\\універ!\\sharping\\MutrixMultiply\\MutrixMultiply\\matrix_second.txt");

           
            if (!SameSize(matrixA, matrixB))
            {
                Console.WriteLine("Неможливо виконати множення матриць.");
                return;
            }

            List<List<int>> resultMatrix = MultiplyMatrices(matrixA, matrixB);

            WriteMatrixToFile("D:\\універ!\\sharping\\MutrixMultiply\\MutrixMultiply\\result.txt", resultMatrix);

            Console.WriteLine("Відповідь у файлі result.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }

    static List<List<int>> ReadMatrixFromFile(string filePath)
    {
        List<List<int>> matrix = new List<List<int>>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<int> row = new List<int>();

                    string[] values = line.Split(' ');
                    foreach (string value in values)
                    {
                        row.Add(int.Parse(value));
                    }

                    matrix.Add(row);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при зчитуванні матриці з файлу {filePath}: {ex.Message}");
            throw;
        }

        return matrix;
    }

    static void WriteMatrixToFile(string filePath, List<List<int>> matrix)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (List<int> row in matrix)
                {
                    writer.WriteLine(string.Join(" ", row));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при записі матриці у файл {filePath}: {ex.Message}");
            throw;
        }
    }

    static bool SameSize(List<List<int>> matrixA, List<List<int>> matrixB)
    {
        return matrixA.Count > 0 && matrixA[0].Count == matrixB.Count;
    }

    static List<List<int>> MultiplyMatrices(List<List<int>> matrixA, List<List<int>> matrixB)
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < matrixA.Count; i++)
        {
            List<int> row = new List<int>();

            for (int j = 0; j < matrixB[0].Count; j++)
            {
                int sum = 0;
                for (int k = 0; k < matrixB.Count; k++)
                {
                    sum += matrixA[i][k] * matrixB[k][j];
                }
                row.Add(sum);
            }

            result.Add(row);
        }

        return result;
    }
}
