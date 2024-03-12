using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {

            string first_path = "C:\\Users\\Златомира\\source\\repos\\C#\\Severylova\\AddSub\\AdditionalSubtraction\\FIrstMatrix.txt";
            string second_path = "C:\\Users\\Златомира\\source\\repos\\C#\\Severylova\\AddSub\\AdditionalSubtraction\\SecondMatrix.txt";


            List<List<double>> first_matrix = Operations.Read(first_path);
            List<List<double>> second_matrix = Operations.Read(second_path);

            Console.WriteLine("First Matrix:");
            Operations.Print(first_matrix);

            Console.WriteLine("\nSecond Matrix:");
            Operations.Print(second_matrix);

            Console.WriteLine("\nAdditional:");
            Operations.Additional(first_matrix, second_matrix);

            Console.WriteLine("\nSubtraction:");
            Operations.Subtraction(first_matrix, second_matrix);

            Console.ReadKey();
        }
    }
}
