using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(18);
            list.Add(10);
            Console.Write("Linked list contains: ");
            list.Print();
            Console.WriteLine("First element is {0}", list.Get());
            Console.WriteLine("Last element is {0}", list.GetLast());
            list.Add(12);
            Console.Write("After adding an element, list contains: ");
            list.Print();
            list.AddAtIndex(1, 15); // Add 15 at index 1
            Console.Write("After adding an element at index 1, list contains: ");
            list.Print();
            list.AddLast(20);
            Console.Write("After adding an element at the end, list contains: ");
            list.Print();
            list.RemoveAtIndex(1); // Remove element at index 1
            Console.Write("After removing an element at index 1, list contains: ");
            list.Print();
            list.Remove(); // Remove the first element
            Console.Write("After removing the first element, list contains: ");
            list.Print();
            list.RemoveLast(); // Remove the last element
            Console.Write("After removing the last element, list contains: ");
            list.Print();
            Console.ReadKey();
        }

    }
}


