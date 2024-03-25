using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[,] students = new string[,]
            {
                {"Zlatomyra", "Severylova", "18", "zlatsev@gmail.com" },
                {"Julia", "Malynovska", "18", "julia@gmail.com"},
                {"Jon", "Bart", "23", "jonbart@gmil.com" }
            };

                ITarget target = new Adapter();
                target.ProcessStudents(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           

            Console.ReadKey();
            
        }
    }
}
