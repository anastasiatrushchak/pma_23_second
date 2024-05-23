using System;

namespace ArrayList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>(8);
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
            list.Append(6);
            list.Append(7);
            list.Append(8);
            list.Remove(6);
            list.Insert(2, 10);
            list.Append(11);

            Console.WriteLine(list);
        }
    }
}
