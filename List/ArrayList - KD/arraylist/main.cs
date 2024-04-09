using System;

class Program
{
    static void Main(string[] args)
    {
        ArrayList<int> myList = new ArrayList<int>();

        Console.WriteLine("Початковий список:");
        Console.WriteLine(myList);
        Console.WriteLine($"Кількість елементів: {myList.Count}");

        if (myList.Count > 8)
        {
            while (myList.Count > 8)
            {
                myList.RemoveAt(0); 
            }
        }

        Console.WriteLine("\nСписок після врахування 8 елементів:");
        Console.WriteLine(myList);
        Console.WriteLine($"Кількість елементів: {myList.Count}");


        Console.WriteLine("Початковий список:");
        Console.WriteLine(myList);
        Console.WriteLine($"Кількість елементів: {myList.Count}");

        // Відняти два елементи
        myList.Remove(70);
        myList.Remove(80);

        Console.WriteLine("\nСписок після віднімання двох елементів:");
        Console.WriteLine(myList);
        Console.WriteLine($"Кількість елементів: {myList.Count}");

        // Додати нові елементи
        myList.Append(110);
        myList.Append(120);

        Console.WriteLine("\nСписок після додавання двох нових елементів:");
        Console.WriteLine(myList);
        Console.WriteLine($"Кількість елементів: {myList.Count}");
    }
}
