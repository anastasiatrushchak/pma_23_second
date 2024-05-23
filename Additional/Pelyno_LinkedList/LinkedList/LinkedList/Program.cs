using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("---------------List after adding elements:--------------------");
                LinkedList<int> list = new LinkedList<int>(new List<int> { 1, 2, 3});
                list.Insert(2, 4);
                list.RemoveAt(1);

                Console.WriteLine();
                
                //Console.WriteLine("-----------------------List after adding elements:--------------");
                //list.PrintList();
                //list.AddLast(6);
                //list.AddFirst(7);
                //list.AddLast(8);
                //list.AddLast(9);
                //list.PrintList();
                //Console.WriteLine("-------------List after deleting first and last elements:--------------");
                //list.RemoveFirst();
                //list.RemoveLast();
                //list.PrintList();
                //Console.WriteLine("---------------------List after adding element after node with value 2:------------------");
                //Node<int> node = list.Find(2);
                //list.AddAfter(node, 5);
                //list.PrintList();
                //Console.WriteLine("---------------------List after adding element before node with value 4:------------------");
                //node = list.Find(4);
                //list.AddBefore(node, 10);
                //list.PrintList();
                //Console.WriteLine("----------------------List after deleting element with value 3:-----------------");
                //node = list.Find(3);
                //list.Remove(node);
                //list.PrintList();
                //Console.WriteLine("----------------------List after adding element at index 2:-----------------");
                //list.Insert(2, 11);
                //list.PrintList();
                //Console.WriteLine("----------------------List after removing element at index 1:-----------------");
                //list.RemoveAt(1);
                //list.PrintList();
                //Console.WriteLine("--------------List after clear:--------------------");
                //list.Clear();
                //list.PrintList();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
