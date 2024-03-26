using System;
namespace ConsoleApplication6
{
    using System.Collections.Generic;

    public class ItemCollection
    {
        private static ItemCollection instance;
        private readonly List<Item> items;
        private static readonly object lockObject = new object();

        private ItemCollection()
        {
            items = new List<Item>();
        }

        public static ItemCollection GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ItemCollection();
                    }
                }
            }
            return instance;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Added item: {item.Name} with ID: {item.Id}");
        }

        public void DisplayItems()
        {
            Console.WriteLine("Items in the collection:");
            foreach (var item in items)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
            }
        }
    }


}