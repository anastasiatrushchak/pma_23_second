using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
           
            List<List<int>> matrixA = ReadMatrixFromFile("D:\\універ!\\sharping\\MatrixAdd\\MatrixAdd\\matrix_first.txt");
            List<List<int>> matrixB = ReadMatrixFromFile("D:\\універ!\\sharping\\MatrixAdd\\MatrixAdd\\matrix_second.txt");

            
            if (!SameSize(matrixA, matrixB))
            {
                Console.WriteLine("Матриці мають різний розмір.");
                return;
            }

            List<List<int>> sumMatrix = AddMatrices(matrixA, matrixB);
            List<List<int>> subtractMatrix = SubtractMatrices(matrixA, matrixB);

           
            WriteMatrixToFile("D:\\універ!\\sharping\\MatrixAdd\\MatrixAdd\\sumMatrix.txt", sumMatrix);
            WriteMatrixToFile("D:\\універ!\\sharping\\MatrixAdd\\MatrixAdd\\subtructMatrix.txt", subtractMatrix);

            Console.WriteLine("Загляяяяянь у файли  sumMatrix та subtructMatrix");
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
        try
        {
            if (matrixA.Count != matrixB.Count)
            {
                return false;
            }

            for (int i = 0; i < matrixA.Count; i++)
            {
                if (matrixA[i].Count != matrixB[i].Count)
                {
                    return false;
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка при перевірці валідності матриць: {ex.Message}");
            throw;
        }
    }

    static List<List<int>> AddMatrices(List<List<int>> matrixA, List<List<int>> matrixB)
    {
        List<List<int>> result = new List<List<int>>();

        try
        {
            for (int i = 0; i < matrixA.Count; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j < matrixA[i].Count; j++)
                {
                    row.Add(matrixA[i][j] + matrixB[i][j]);
                }

                result.Add(row);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка при додаванні матриць: {ex.Message}");
            throw;
        }

        return result;
    }

    static List<List<int>> SubtractMatrices(List<List<int>> matrixA, List<List<int>> matrixB)
    {
        List<List<int>> result = new List<List<int>>();

        try
        {
            for (int i = 0; i < matrixA.Count; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j < matrixA[i].Count; j++)
                {
                    row.Add(matrixA[i][j] - matrixB[i][j]);
                }

                result.Add(row);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка при відніманні матриць: {ex.Message}");
            throw;
        }

        return result;
    }
}
