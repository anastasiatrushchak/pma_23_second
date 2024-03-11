using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomMatrix matrix1 = new CustomMatrix();
            CustomMatrix matrix2 = new CustomMatrix();
            try
            {

                matrix1 = MatrixService.LoadMatrixFromFile("D:\\Максим диск D\\Універ\\2 курс\\Програмування C#\\MatrixLNU\\MatrixLNU\\MatrixInput1.txt");


                matrix2 = MatrixService.LoadMatrixFromFile("D:\\Максим диск D\\Універ\\2 курс\\Програмування C#\\MatrixLNU\\MatrixLNU\\MatrixInput2.txt");
                Console.WriteLine("The first matrix entered:");
                Console.WriteLine(matrix1);

                Console.WriteLine("The second matrix entered:");
                Console.WriteLine(matrix2);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("One or both matrix files not found.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                CustomMatrix sum = CustomMatrix.Add(matrix1, matrix2);
                Console.WriteLine("The sum of two matrices:");
                Console.WriteLine(sum);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                CustomMatrix difference = CustomMatrix.Subtract(matrix1, matrix2);
                Console.WriteLine("The difference of two matrices:");
                Console.WriteLine(difference);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                CustomMatrix product = CustomMatrix.Multiply(matrix1, matrix2);

                Console.WriteLine("The product of two matrices:");
                Console.WriteLine(product);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }


    }
}
