using System;

namespace ArrayList;

class Program
{
    static void Main(string[] args)
    {
        ArrayList<int> my_list = new ArrayList<int>(8);
        my_list.Add(1);
        my_list.Add(2);
        my_list.Add(3);
        my_list.Add(5);
        my_list.Add(2);
        my_list.Add(1);
        my_list.Add(8);
        my_list.Add(9);
        


        
        Console.WriteLine(my_list);

        my_list.Remove(7);
        Console.WriteLine(my_list);

        Console.WriteLine(my_list.Count);
        my_list.Clear();
        Console.WriteLine(my_list);
    }
}
