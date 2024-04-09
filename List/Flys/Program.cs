using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
          private static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(new List<int> { 1, 2, 3, 4, 5 });
            list.Append(6);
            list.Append(7);
            list.Insert(2, 0);
            list.Remove(0);
            Console.WriteLine(string.Join(", ", list.Display()));
        }
    }
}