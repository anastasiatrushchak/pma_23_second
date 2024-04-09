using Lab_7;
using System.Collections;
using System.Runtime.CompilerServices;

public static class Program
{
    public static void Main()
    {
        try
        {
            MyArrayList<int> arrayList = new(5);
            for (int i = 0; i < 10; i++)
            {
                arrayList.Add(i);
                Console.WriteLine(arrayList.ToString());
            }
            Console.WriteLine(arrayList.Contains(0));
            Console.WriteLine(arrayList.Contains(100));
            arrayList.Remove(0);
            Console.WriteLine(arrayList);
            arrayList.Clear();
            arrayList.AddRange(new List<int> { 9, 8, 7, 6 });
            Console.WriteLine(arrayList);
            arrayList.AddRange(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(arrayList);
            arrayList.RemoveAt(0);
            Console.WriteLine(arrayList);

            Console.WriteLine("List test: ");
            MyLinkedList<int> myList = new MyLinkedList<int>();

            myList.AddLast(1);
            myList.AddLast(2);
            myList.AddLast(3);

            Console.WriteLine("Initial list: " + myList);

            Console.WriteLine("Value at index 1: " + myList.GetValue(1));

            myList.AddFirst(0);
            Console.WriteLine("List after adding 0 at the beginning: " + myList);

            myList.Insert(2, 10);
            Console.WriteLine("List after inserting 10 at index 2: " + myList);

            myList.Clear();
            Console.WriteLine("List after clearing: " + myList);

            MyLinkedList<int> anotherList = new MyLinkedList<int>(new List<int> { 4, 5, 6 });
            Console.WriteLine("Another list: " + anotherList);

            Console.WriteLine("Does the list contain 5? " + anotherList.Contains(5));

            anotherList.Remove(5);
            Console.WriteLine("List after removing 5: " + anotherList);

            anotherList.RemoveAt(1);
            Console.WriteLine("List after removing element at index 1: " + anotherList);
        
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}