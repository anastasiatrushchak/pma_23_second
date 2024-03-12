using System;
using System.IO;

class MatrixOperations
{
    static void Main()
    {
        try
        {
            Matrix matrix1 = Matrix.ReadFromFile("C:\\Users\\yours\\source\\repos\\ConsoleApp4\\ConsoleApp4\\Matrix1.txt");
            Matrix matrix2 = Matrix.ReadFromFile("C:\\Users\\yours\\source\\repos\\ConsoleApp4\\ConsoleApp4\\Matrix2.txt");

            Console.WriteLine("Matrix 1:");
            matrix1.Display();

            Console.WriteLine("\nMatrix 2:");
            matrix2.Display();

            Matrix sum = matrix1.Add(matrix2);
            Console.WriteLine("\nSum of matrices:");
            sum.Display();

            Matrix difference = matrix1.Subtract(matrix2);
            Console.WriteLine("\nDifference of matrices:");
            difference.Display();

            Matrix multiply = matrix1.Multiply(matrix2);
            Console.WriteLine("\nMult of matrices:");
            multiply.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

class Matrix
{
    private int[,] data;

    public Matrix(int[,] data)
    {
        if (data.GetLength(0) != 3 || data.GetLength(1) != 3)
        {
            throw new ArgumentException("Matrix must be of size 3x3.");
        }

        this.data = data;
    }

    public static Matrix ReadFromFile(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            int[,] matrixData = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                string[] rowValues = lines[i].Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    matrixData[i, j] = int.Parse(rowValues[j]);
                }
            }

            return new Matrix(matrixData);
        }
        catch (Exception ex)
        {
            throw new IOException($"Error reading matrix from file {fileName}: {ex.Message}");
        }
    }

    public Matrix Add(Matrix other)
    {
        int[,] resultData = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultData[i, j] = this.data[i, j] + other.data[i, j];
            }
        }

        return new Matrix(resultData);
    }

    public Matrix Subtract(Matrix other)
    {
        int[,] resultData = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultData[i, j] = this.data[i, j] - other.data[i, j];
            }
        }

        return new Matrix(resultData);
    }

    public Matrix Multiply(Matrix other)
    {
        int[,] resultData = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    resultData[i, j] += this.data[i, k] * other.data[k, j];
                }
            }
        }

        return new Matrix(resultData);
    }

    public void Display()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{data[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
