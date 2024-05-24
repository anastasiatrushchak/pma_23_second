class ArrayList
{
    private List<int> array;
    private double size;
    private double capacity;


    public ArrayList(List<int> array)
    {
        this.array = array;
        this.size = array.Count;
        this.capacity = 1.5 * array.Count + 1;
    }

    public void Append(int el)
    {
        ++size;
        if (size < capacity)
        {
            array.Add(el);
        }
        else
        {
            capacity = capacity * 1.5 + 1;
            List<int> temp = new List<int>(array);
            array.Clear();
            foreach (int i in temp)
            {
                array.Add(i);
            }
            array.Add(el);
        }
    }
   
    public int Remove(int value)
    {
        int index = -1;

        for (int i = 0; i < array.Count; i++)
        {
            if (array[i] == value)
            {
                index = i;
                break;
            }
        }
        if (index != -1)
        {
            for (int i = index; i < array.Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array.RemoveAt(array.Count - 1);
            --size; 
        }
        return index;
    }

    public void Clear()
    {
        array.Clear();
    }

    public void Insert(int index, int value)
    {
        ++size;
        if (size < capacity)
        {
            array.Add(0);
            for (int i = array.Count - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = value;
        }
        else
        {
            capacity = capacity * 1.5 + 1;
            List<int> temp = new List<int>(array);
            array.Clear();
            foreach (int i in temp)
            {
                array.Add(i);
            }
            array.Add(0);
            for (int i = array.Count - 1; i > index; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = value;
        }
    }

    public static void Main(string[] args)
    {
        List<int> array = new List<int> { 4, 5, 6};
        ArrayList l = new ArrayList(array);
        l.Append(5);
        l.Append(7);
        l.Remove(5);
        l.Insert(1, 9);
        l.Append(50);
        l.Append(5);
        l.Append(34);
        l.Append(66);
       

        


        foreach (int i in l.array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine(l.size);
        Console.WriteLine(l.capacity);
    }
}
