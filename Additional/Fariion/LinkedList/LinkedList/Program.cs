using System;
using System.Collections.Generic;
namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> a = new LinkedList<int>(new List<int> { 1, 2, 3 });

        a.Append(1);
        a.Append(5);
        a.Append(2);
        a.Append(1);
        a.Append(9);
        a.Append(55);
        a.Append(6);
        a.Append(73);
        Console.WriteLine(a);

        a.Insert(-5, 24);
        a.Remove(19);
        a.Clear(5);
        Console.WriteLine(a);

        a.ClearList();
        Console.WriteLine(a);
    }
}
