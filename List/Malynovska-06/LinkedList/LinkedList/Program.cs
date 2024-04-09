using System;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(0);
            list.Add(3);
            list.AddByIndex(0, 20);
            Console.WriteLine("List:");
            list.Write();
            list.Remove(1);
            Console.WriteLine("List after removing element with value 1:");
            list.Write(); 

            list.RemoveByIndex(2);
            Console.WriteLine("List after removing element at index 2:");
            list.Write(); 
            Console.WriteLine("Size of list: " + list.Size); 
        }
    }


}
