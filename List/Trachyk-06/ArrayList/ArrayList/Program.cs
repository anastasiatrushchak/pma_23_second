using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine("Всi елементи:");
            PrintArrayList(list);

            list.Remove(2);

            Console.WriteLine("\nЕлементи пiсля видалення:");
            PrintArrayList(list);

            list.Insert(1, 5);

            Console.WriteLine("\nЕлементи пiсля вставки по iндексу:");
            PrintArrayList(list);

            list.Clear();
            Console.WriteLine("\nСписок пiсля очищення:");
            Console.WriteLine("Кiлькiсть елементiв: " + list.Count);
        }

        static void PrintArrayList(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
    