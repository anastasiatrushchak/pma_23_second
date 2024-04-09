using System;

namespace ArrayList
{

    class Program
    {
        static void Main(string[] args)
        {

            ArrayList<int> arrayList = new ArrayList<int>(8);
            object[] arr = { 1, 28, 5, 12, 3, 4, 5, 4 };
            foreach (int i in arr)
            {
                arrayList.Add(i);
            }


            Console.WriteLine("-------Original ArrayList-------");
            arrayList.Printed();
            Console.WriteLine("-------To ArrayList add 10 at the end-------");
            arrayList.Add(10);
            arrayList.Printed();
            Console.WriteLine("-------From ArrayList delete element on 2 position-------");
            try
            {
                arrayList.Delete(2);
                arrayList.Printed();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Deletion failed.");
            }


            Console.WriteLine("-------From ArrayList we try delete element on 58 position,which is not exist-------");
            try
            {
                arrayList.Delete(58);

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Deletion failed.");
            }
            Console.WriteLine("-------To ArrayList we add element 18 on 0 position-------");
            try
            {
                arrayList.Insert(0, 18);
                arrayList.Printed();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index or element. Insertion failed.");
            }
            Console.WriteLine("-------To ArrayList we try to add element 13 on 28 position, which is not exist-------");
            try
            {
                arrayList.Insert(54, 13);
                arrayList.Printed();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index or element. Insertion failed.");
            }
            arrayList.Clear();
            Console.WriteLine("-------ArrayList is cleared-------");
            arrayList.Printed();
        }
    }
}