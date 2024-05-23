using ArrayList;
using System;

class Program
{
    static void Main(string[] args)
    {
        ArrayList<int> arrayList = new ArrayList<int>(5);
        arrayList.WriteCapacity();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);
        arrayList.Add(5);
        arrayList.WriteCapacity();
        arrayList.Add(1);
        arrayList.WriteCapacity();
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);
        arrayList.WriteCapacity();
        arrayList.Add(5);

        Console.WriteLine("ArrayList:");
        arrayList.Write(); 
        arrayList.Delete(2);
        Console.WriteLine("ArrayList after deletion:");
        arrayList.Write();
        arrayList.WriteCapacity();

        arrayList.PutByIndex(100, 6); 

        Console.WriteLine("ArrayList insertion:");
        arrayList.Write();
        arrayList.WriteCapacity();

    }
}