class MatrixOperation
{
    static void Main()
    {
        try
        {
            int[,] matrixA = ReadMatrixFromFile("matrixA.txt");
            int[,] matrixB = ReadMatrixFromFile("matrixB.txt");

            Console.WriteLine("Матриця A:");
            PrintMatrix(matrixA);

            Console.WriteLine("Матриця B:");
            PrintMatrix(matrixB);

            int[,] sumMatrix = AddMatrices(matrixA, matrixB);

            Console.WriteLine("Результат додавання матриць:");
            PrintMatrix(sumMatrix);

            int[,] diffMatrix = SubtractMatrices(matrixA, matrixB);

            Console.WriteLine("Результат віднімання матриць:");
            PrintMatrix(diffMatrix);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static int[,] ReadMatrixFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        int rowCount = lines.Length;
        int colCount = lines[0].Split(' ').Length;

        int[,] matrix = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            string[] values = lines[i].Split(' ');

            for (int j = 0; j < colCount; j++)
            {
                if (int.TryParse(values[j], out int value))
                {
                    matrix[i, j] = value;
                }
                else
                {
                    throw new Exception($"Некоректні дані у файлі {fileName}");
                }
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowCount = matrixA.GetLength(0);
        int colCount = matrixA.GetLength(1);
        int[,] resultMatrix = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowCount = matrixA.GetLength(0);
        int colCount = matrixA.GetLength(1);
        int[,] resultMatrix = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return resultMatrix;
    }
}
