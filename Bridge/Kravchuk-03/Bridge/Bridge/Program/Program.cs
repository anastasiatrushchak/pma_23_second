using System;

namespace Bridge
{
  
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyColor pink = new Pink();
                MyColor purple = new Purple();

                Shape round = new Round(-5,pink);
                round.Create();
                Console.WriteLine($"Area:{round.Area()}, Perimeter:{round.Per()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
