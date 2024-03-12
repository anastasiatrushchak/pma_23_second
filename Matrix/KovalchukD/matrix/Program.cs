using System;
using System.IO;

class MatrixOperations
{
    static void Main()
    {
        try
        {
            int[,] matrixA = ReadMatrixFromFile("C:\\c++\\modul 1\\8(3)\\matrixA.txt");
            int[,] matrixB = ReadMatrixFromFile("C:\\c++\\modul 1\\8(3)\\matrixB.txt");


            if (matrixA.GetLength(0) != matrixB.GetLength(0) || matrixA.GetLength(1) != matrixB.GetLength(1))
            {
                throw new ArgumentException("Матриці мають різні розміри.");
            }

            int[,] sumMatrix = AddMatrices(matrixA, matrixB);
            int[,] diffMatrix = SubtractMatrices(matrixA, matrixB);
            int[,] productMatrix = MultiplyMatrices(matrixA, matrixB);

            // Запис результатів у файл
            string resultsFilePath = "C:\\c++\\modul 1\\8(3)\\result.txt";
            WriteResultsToFile(resultsFilePath, sumMatrix, diffMatrix, productMatrix);

            Console.WriteLine("Операції виконано успішно. Результати записані у файл result.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Помилка: Один або обидва файли не знайдено.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static void WriteResultsToFile(string filePath, int[,] sumMatrix, int[,] diffMatrix, int[,] productMatrix)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Результат додавання:");
            WriteMatrix(writer, sumMatrix);

            writer.WriteLine("\nРезультат віднімання:");
            WriteMatrix(writer, diffMatrix);

            writer.WriteLine("\nРезультат множення:");
            WriteMatrix(writer, productMatrix);
        }
    }

    static void WriteMatrix(StreamWriter writer, int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                writer.Write(matrix[i, j] + " ");
            }
            writer.WriteLine();
        }
    }

    static int[,] ReadMatrixFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException();
        }

        string[] lines = File.ReadAllLines(fileName);
        int rows = lines.Length;
        int columns = lines[0].Split(' ').Length;

        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i].Split(' ');
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(values[j]);
            }
        }

        return matrix;
    }

    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);
        int columnsB = matrixB.GetLength(1);
        int[,] result = new int[rowsA, columnsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int k = 0; k < columnsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }
}
