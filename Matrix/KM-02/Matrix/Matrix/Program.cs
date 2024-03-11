using System;
using System.IO;
using System.Threading.Tasks;

class MatrixOperations
{
    static int[,] matrixA;
    static int[,] matrixB;
    static int[,] matrixAdd;
    static int[,] matrixSub;
    static int[,] matrixMult;

    static void PrintMatrix(int[,] mat)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Subtract()
    {
        if (matrixA.GetLength(0) != matrixB.GetLength(0) || matrixA.GetLength(1) != matrixB.GetLength(1))
        {
            Console.WriteLine("Matrix subtraction is not possible. Matrices have different dimensions.");
            return;
        }

        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        matrixSub = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrixSub[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }
    }

    static void Add()
    {
        if (matrixA.GetLength(0) != matrixB.GetLength(0) || matrixA.GetLength(1) != matrixB.GetLength(1))
        {
            Console.WriteLine("Matrix addition is not possible. Matrices have different dimensions.");
            return;
        }

        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        matrixAdd = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrixAdd[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
    }

    static void Mult()
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        if (colsA != matrixB.GetLength(0))
        {
            Console.WriteLine("Matrix multiplication is not possible. Number of columns in Matrix A must be equal to the number of rows in Matrix B.");
            return;
        }

        matrixMult = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                matrixMult[i, j] = sum;
            }
        }
    }

    static void Main(string[] args)
    {
        matrixA = ReadMatrixFromFile("C:\\Users\\kravc\\source\\repos\\Sum_and_Sub_Matrix\\Sum_and_Sub_Matrix\\A.txt");
        matrixB = ReadMatrixFromFile("C:\\Users\\kravc\\source\\repos\\Sum_and_Sub_Matrix\\Sum_and_Sub_Matrix\\B.txt");

        if (matrixA == null || matrixB == null)
        {
            Console.WriteLine("Matrix can't be read.");
            return;
        }

        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);
        Console.WriteLine("Matrix B:");
        PrintMatrix(matrixB);

        Add();
        Subtract();
        Mult();

        if (matrixAdd != null)
        {
            Console.WriteLine("Sum of Matrix A and B:");
            PrintMatrix(matrixAdd);
        }

        if (matrixSub != null)
        {
            Console.WriteLine("Subtraction of Matrix A and B:");
            PrintMatrix(matrixSub);
        }

        if (matrixMult != null)
        {
            Console.WriteLine("Multiplication of Matrix A and B:");
            PrintMatrix(matrixMult);
        }
    }

    static int[,] ReadMatrixFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            int rows = lines.Length;
            int cols = lines[0].Split(' ').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }
        catch (Exception)
        {
            return null;
        }
    }
}
