using System;
using System.IO;

class MatrixOperations
{
    public static void Main(string[] args)
    {
        int[,] matrix1 = ReadMatrixFromFile("matrix1.txt");
        int[,] matrix2 = ReadMatrixFromFile("matrix2.txt");

        if (matrix1 == null || matrix2 == null)
        {
            Console.WriteLine("Не вдалося прочитати матриці з файлу.");
            return;
        }

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nMatrix 2:");
        PrintMatrix(matrix2);

        Console.WriteLine("\nAddition result:");
        int[,] additionResult = AddMatrices(matrix1, matrix2);
        PrintMatrix(additionResult);

        Console.WriteLine("\nSubtraction result:");
        int[,] subtractionResult = SubtractMatrices(matrix1, matrix2);
        PrintMatrix(subtractionResult);

        Console.WriteLine("\nMultiplication result:");
        int[,] MultiplyResult = MultiplyMatrices(matrix1, matrix2);
        PrintMatrix(MultiplyResult);
    }

    public static int[,] ReadMatrixFromFile(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                int rows = 0;
                int cols = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    rows++;
                    string[] values = line.Trim().Split(' ');
                    cols = Math.Max(cols, values.Length);
                }

                
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                int[,] matrix = new int[rows, cols];
                int currentRow = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Trim().Split(' ');
                    for (int j = 0; j < values.Length; j++)
                    {
                        matrix[currentRow, j] = int.Parse(values[j]);
                    }
                    currentRow++;
                }

                return matrix;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Під час читання матриці сталася помилка: {ex.Message}");
            return null;
        }
    }

    public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result; 
    }

    public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result; 
    }
    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            Console.WriteLine("Неможливо помножити матриці: недійсні розміри.");
            return null;
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}