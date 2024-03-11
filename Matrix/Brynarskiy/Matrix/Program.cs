using System;
using System.IO;

class MatrixOperation
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("1. Додавання матриць");
            Console.WriteLine("2. Віднімання матриць");

            int choice = int.Parse(Console.ReadLine());

            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Невірний вибір.");
                return;
            }

            Console.WriteLine("Введіть ім'я файлу для першої матриці:");
            string file1 = Console.ReadLine();

            Console.WriteLine("Введіть ім'я файлу для другої матриці:");
            string file2 = Console.ReadLine();

            Matrix matrix1 = Matrix.ReadFromFile(file1);
            Matrix matrix2 = Matrix.ReadFromFile(file2);

            Matrix result;

            if (choice == 1)
                result = matrix1.Add(matrix2);
            else
                result = matrix1.Subtract(matrix2);

            Console.WriteLine("Результат:");
            result.Display();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}

class Matrix
{
    private int[,] data;

    public Matrix(int[,] data)
    {
        if (data.GetLength(0) != 3 || data.GetLength(1) != 3)
            throw new ArgumentException("Розмір матриці повинен бути 3 на 3.");

        this.data = data;
    }

    public Matrix Add(Matrix other)
    {
        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                result[i, j] = this.data[i, j] + other.data[i, j];

        return new Matrix(result);
    }

    public Matrix Subtract(Matrix other)
    {
        int[,] result = new int[3, 3];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                result[i, j] = this.data[i, j] - other.data[i, j];

        return new Matrix(result);
    }

    public void Display()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{data[i, j]} ");

            Console.WriteLine();
        }
    }

    public static Matrix ReadFromFile(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);

            int[,] matrixData = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                string[] row = lines[i].Split(' ');

                for (int j = 0; j < 3; j++)
                    matrixData[i, j] = int.Parse(row[j]);
            }

            return new Matrix(matrixData);
        }
        catch (Exception ex)
        {
            throw new Exception($"Помилка зчитування з файлу: {ex.Message}");
        }
    }
}
