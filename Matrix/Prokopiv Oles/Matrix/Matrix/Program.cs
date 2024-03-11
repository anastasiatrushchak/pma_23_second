using System;
using System.IO;

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

                matrix1 = Service.ReadMatrixFromFile("C:\\lnu\\program\\matrix\\Matrix\\Matrix\\matrix1.txt");


                matrix2 = Service.ReadMatrixFromFile("C:\\lnu\\program\\matrix\\Matrix\\Matrix\\matrix2.txt");
                Console.WriteLine("matrix 1:");
                Console.WriteLine(matrix1);

                Console.WriteLine("matrix 2:");
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
                CustomMatrix sum = matrix1 + matrix2;
                Console.WriteLine("sum:");
                Console.WriteLine(sum);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                CustomMatrix difference = matrix1 - matrix2;
                Console.WriteLine("difference:");
                Console.WriteLine(difference);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {
                CustomMatrix product = matrix1 * matrix2;

                Console.WriteLine("product:");
                Console.WriteLine(product);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }          
        }

        
    }
}