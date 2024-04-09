using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Array<int> list = new Array<int>(8);

            Console.WriteLine("Push 8 elem: ");
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(5);
            list.Push(6);
            list.Push(7);
            list.Push(8);
            Console.WriteLine(list);

            Console.WriteLine("Pop by index 7");
            list.PopByIndex(7);
            Console.WriteLine(list);
            

            Console.WriteLine("Push: ");
            list.Push(9);
            list.Push(10);
            Console.WriteLine(list);

            Console.WriteLine("Pop last element");
            list.Pop();
            list.Pop();
            Console.WriteLine(list);

        }
    }
}
