using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<List<double>> first = Matrix.ReadMatrix("matrix1.txt");
            List<List<double>> second = Matrix.ReadMatrix("matrix2.txt");
            Console.WriteLine("matrix 1");
            Matrix.PrintMatrix(first);
            Console.WriteLine("matrix 2");
            Matrix.PrintMatrix(second);
            while(true)
            {
                Console.WriteLine("Which operation do you want to calculate?");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Exit");
                string operation = Console.ReadLine();
                if (operation.Equals("1"))
                {
                    Console.WriteLine("Result of addition:");
                    Matrix.PrintMatrix(Matrix.AddMatrices(first, second));
                }
                else if (operation.Equals("2"))
                {
                    Console.WriteLine("Result of subtraction:");
                    Matrix.PrintMatrix(Matrix.SubtractMatrices(first, second));
                }
                else if (operation.Equals("3"))
                {
                    Console.WriteLine("Result of multiplication:");
                    Matrix.PrintMatrix(Matrix.MultiplyMatrices(first, second));
                }
                else if (operation.Equals("4"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You should choose between 1 and 4!");
                }
            }
           

        }
    }
}
