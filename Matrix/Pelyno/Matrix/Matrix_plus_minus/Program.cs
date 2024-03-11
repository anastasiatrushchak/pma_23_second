using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    

    class Matrix
    {
        private double[][] matrix;

        public Matrix(double[][] matrix)
        {
            this.matrix = matrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var row in matrix)
            {
                sb.AppendLine(string.Join(" ", row));
            }
            return sb.ToString();
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            if (first.matrix.Length != second.matrix.Length || first.matrix[0].Length != second.matrix[0].Length)
            {
                throw new InvalidOperationException("Matrix dimensions do not match");
            }

            int rows = first.matrix.Length;
            int cols = first.matrix[0].Length;
            double[][] result = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                result[i] = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    result[i][j] = first.matrix[i][j] + second.matrix[i][j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            if (first.matrix.Length != second.matrix.Length || first.matrix[0].Length != second.matrix[0].Length)
            {
                throw new InvalidOperationException("Matrix dimensions do not match");
            }

            int rows = first.matrix.Length;
            int cols = first.matrix[0].Length;
            double[][] result = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                result[i] = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    result[i][j] = first.matrix[i][j] -second.matrix[i][j];
                }
            }

            return new Matrix(result);
        }
        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.matrix[0].Length != second.matrix.Length)
            {
                throw new InvalidOperationException("Matrix dimensions do not match");
            }
            double[][] result = new double[first.matrix.Length][];
            for (int i = 0; i < first.matrix.Length; i++)
            {
                result[i] = new double[first.matrix[0].Length];
                for (int j = 0; j < second.matrix[0].Length; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < second.matrix.Length; k++)
                    {
                        sum += first.matrix[i][k] * second.matrix[k][j];
                    }
                    result[i][j] = sum;
                }
            }
            return new Matrix(result);
        }


        public static Matrix Reading(string fileName)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(fileName);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File Not Found");
            }

            double[][] matrix = lines
                .Select(line =>
                {
                    string[] elements = line.Split();
                    if (elements.Length != lines[0].Split().Length)
                    {
                        throw new ArgumentException("Incomplete matrix input");
                    }
                    return elements.Select(double.Parse).ToArray();
                })
                .ToArray();

            return new Matrix(matrix);
        }

        public void Writing(Matrix matrixFirst, Matrix matrixSecond, string resultFileName, string action, char sign)
        {
            string content = $"{action}{matrixFirst}\n{sign}\n{matrixSecond}\n=\n{this}\n";
            File.AppendAllText(resultFileName, content, Encoding.UTF8);
        }
    }

    static void Main()
    {
        string FILE_ERROR = "File Not Found";
        string matrixOneFile = "D:\\C#\\Programming\\Matrix_plus_minus\\Matrix_plus_minus\\matrix_one.txt";
        string matrixTwoFile = "D:\\C#\\Programming\\Matrix_plus_minus\\Matrix_plus_minus\\matrix_two.txt";
        string resultFile = "D:\\C#\\Programming\\Matrix_plus_minus\\Matrix_plus_minus\\result.txt";

        Matrix matrixOne, matrixTwo;
        try
        {
            matrixOne = Matrix.Reading(matrixOneFile);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine(FILE_ERROR);
            Environment.Exit(-1);
            return;
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Not enough data in matrix1");
            Environment.Exit(-1);
            return;
        }

        try
        {
            matrixTwo = Matrix.Reading(matrixTwoFile);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine(FILE_ERROR);
            Environment.Exit(-1);
            return;
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Not enough data in matrix 2");
            Environment.Exit(-1);
            return;
        }

        try
        {
            Matrix addRes = matrixOne + matrixTwo;
            Matrix subRes = matrixOne - matrixTwo;
            Matrix mulRes = matrixTwo * matrixOne;
            addRes.Writing(matrixOne, matrixTwo, resultFile, "Addition:\n", '+');
            subRes.Writing(matrixOne, matrixTwo, resultFile, "Subtraction:\n", '-');
            mulRes.Writing(matrixOne, matrixTwo, resultFile, "Multiply:\n", '*');
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(-1);
            return;
        }
    }
}
