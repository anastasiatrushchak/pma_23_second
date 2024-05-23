using ArrayList;

class Program
{
    static void Main(string[] args)
    {
        ArrayList<int> my_list = new ArrayList<int>(8);
        my_list.Add(1);
        my_list.Add(2);
        my_list.Add(3);
        my_list.Add(4);
        my_list.Add(5);
        my_list.Add(6);
        my_list.Add(7);
        my_list.Add(8);
        my_list.Capacity();
        my_list.Add(9);
        Console.WriteLine(my_list);

        my_list.Remove(100);
        Console.WriteLine(my_list);

        my_list.Insert(2, 56);
        Console.WriteLine(my_list);



        my_list.Add(16);
        my_list.Add(28);
        Console.WriteLine(my_list);
        my_list.Capacity();

        my_list.Clear();
        Console.WriteLine(my_list);
        Console.WriteLine(my_list.Count);


    }
}