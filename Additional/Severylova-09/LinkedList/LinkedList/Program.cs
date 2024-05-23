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
            Linked<int> list = new Linked<int>();

            Console.WriteLine("Append to end: ");
            list.AppendToEnd(3);
            list.AppendToEnd(4);
            list.AppendToEnd(5);
            list.AppendToEnd(6);
            list.AppendToEnd(7);
            list.AppendToEnd(8);
            Console.WriteLine(list);

            Console.WriteLine("Append to begin: ");
            list.AppendToBegin(1);
            Console.WriteLine(list);

            Console.WriteLine("Append by index: ");
            list.AppendByIndex(2, 1);
            Console.WriteLine(list);

            Console.WriteLine("Remove by index 7: ");
            list.RemoveByIndex(7);
            Console.WriteLine(list);

            Console.WriteLine("Append to end: ");
            list.AppendToEnd(9);
            list.AppendToEnd(10);
            Console.WriteLine(list);

            Console.WriteLine("Remove: ");
            list.Remove();
            list.Remove();
            Console.WriteLine(list);
        }
    }
}
