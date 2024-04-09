using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Linked
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            Console.WriteLine("Original List:");
            list.Display();

            list.Insert(2, 10);
            Console.WriteLine("List after Insertion:");
            list.Display();

            list.Remove(1);
            Console.WriteLine("List after Removal:");
            list.Display();
        }
    }
}