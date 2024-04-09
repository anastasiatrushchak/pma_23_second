using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>(8);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.Print();
            Console.WriteLine("Capasity:"+list.Capacity);
            try
            {
                list.Delete(6);
                list.Print();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            list.Add(1);
            list.Add(2);
            
            Console.WriteLine("Capasity:"+list.Capacity);
        
        }
    }
}