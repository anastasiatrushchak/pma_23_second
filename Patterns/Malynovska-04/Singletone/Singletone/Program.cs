using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BookService service1 = BookService.getInstance();
                Book harry = new Book("Harry Potter", "Joan Rolling", 2000);
                Book hunger = new Book("Hunger Games", "Susan Collins", 2012);
                service1.AddBook(harry);
                service1.AddBook(hunger);
                Console.WriteLine("service1");
                service1.PrintBooks();


                BookService service2 = BookService.getInstance();
                Console.WriteLine("\nservice2");

                service2.PrintBooks();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
