using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape restangle = new Rectangle(5, 10, new Red());
                Console.WriteLine(restangle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Shape circle = new Circle(8, new Purple());
                Console.WriteLine(circle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Shape triangle = new Triangle(4, 6, 8, new Green());
                Console.WriteLine(triangle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Shape square = new Square(5, new Blue());
                Console.WriteLine(square);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
