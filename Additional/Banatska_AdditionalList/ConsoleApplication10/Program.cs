using System;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.Insert(4, 2);
            list.Delete(1);
            list.Print();
        }
    }
}