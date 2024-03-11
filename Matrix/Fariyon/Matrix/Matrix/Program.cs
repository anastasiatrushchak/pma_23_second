using System;
using System.IO;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {   
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();
            try
            {

                matrix1 = Service.ReadMatrixFromFile("D:\\ЛНУ\\2 курс 2 семестр\\C#\\Matrix\\Matrix\\matrix1.txt");


                matrix2 = Service.ReadMatrixFromFile("D:\\ЛНУ\\2 курс 2 семестр\\C#\\Matrix\\Matrix\\matrix2.txt");
                Console.WriteLine("Matrix 1:");
                Console.WriteLine(matrix1);

                Console.WriteLine("Matrix 2:");
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
                Matrix sum = matrix1 + matrix2;
                Console.WriteLine("Sum:");
                Console.WriteLine(sum);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                Matrix difference = matrix1 - matrix2;
                Console.WriteLine("Difference:");
                Console.WriteLine(difference);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                Matrix product = matrix1 * matrix2;

                Console.WriteLine("Product:");
                Console.WriteLine(product);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }          
        }

        
    }
}