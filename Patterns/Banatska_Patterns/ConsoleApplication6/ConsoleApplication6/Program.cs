using System;

namespace ConsoleApplication6
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ItemCollection collection = ItemCollection.GetInstance();
            collection.AddItem(new Item(1, "Item 1"));
            collection.AddItem(new Item(2, "Item 2"));

            collection.DisplayItems();
        }
    }

}   