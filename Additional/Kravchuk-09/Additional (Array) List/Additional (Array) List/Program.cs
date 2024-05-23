using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional__Array__List
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList<int> arrayList = new ArrayList<int>(8);
            object[] arr = { 1,2,3,4 };
            foreach (int i in arr)
            {
                arrayList.AddElement(i);
            }


            Console.WriteLine("Array List");
            arrayList.Print();
            Console.WriteLine("To ArrayList add 17 at the end");
            arrayList.AddElement(17);
            arrayList.Print();
            Console.WriteLine("From ArrayList remove element on -2 position");
            try
            {
                arrayList.RemoveElement(-2);
                arrayList.Print();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Deletion failed.");
            }

            Console.WriteLine("Add element 22 on 0 position to List");
            try
            {
                arrayList.InsertElement(0, 22);
                arrayList.Print();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index or element. Insertion failed.");
            }
           
            arrayList.Clear();
            Console.WriteLine("Clear List");
            arrayList.Print();
        }
    }
}
   
