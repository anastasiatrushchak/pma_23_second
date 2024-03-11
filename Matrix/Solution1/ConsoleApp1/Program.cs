using System;
using System.IO;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile1 = "NewFile1.txt";
            string inputFile2 = "NewFile2.txt";
            string outputFile = "NewFile3.txt";

            Matrix matrix1, matrix2;
            try
            {
                matrix1 = ReadMatrixFromFile(inputFile1);
                matrix2 = ReadMatrixFromFile(inputFile2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading matrices: {ex.Message}");
                return;
            }

            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                Console.WriteLine("Matrix dimensions must match for addition, subtraction, and multiplication.");
                return;
            }

            Matrix addres = matrix1 + matrix2;
            Matrix subres = matrix1 - matrix2;
            Matrix mulres = matrix1 * matrix2;

            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("Addition:");
                    AppendMatrixToFile(writer, addres);
                    writer.WriteLine("Subtraction:");
                    AppendMatrixToFile(writer, subres);
                    writer.WriteLine("Multiplication:");
                    AppendMatrixToFile(writer, mulres);
                }
                Console.WriteLine("Results written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing results to file: {ex.Message}");
            }
        }

        static void AppendMatrixToFile(StreamWriter writer, Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    writer.Write(matrix[i, j] + " ");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
        }

        // Define Matrix class and ReadMatrixFromFile method here...

        static Matrix ReadMatrixFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int rows = lines.Length;
            int columns = lines[0].Split(' ').Length;

            Matrix matrix = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                string[] elements = lines[i].Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(elements[j]);
                }
            }

            return matrix;
        }
    }

    class Matrix
    {
        private int[,] data;

        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException("Matrix dimensions must match for addition.");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException("Matrix dimensions must match for subtraction.");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
            {
                throw new ArgumentException("Number of columns in the first matrix must match number of rows in the second matrix for multiplication.");
            }

            Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
    }
}

