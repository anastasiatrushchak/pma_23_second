using System;
using System.Linq;

public class ArrayList
{
    private int capacity;
    private int[] data;
    private int length;

    public ArrayList()
    {
        capacity = 1;
        data = new int[capacity];
        length = 0;
    }

    private void Resize()
    {
        int newCapacity = (int)(1.5 * capacity) + 1;
        int[] newData = new int[newCapacity];
        Array.Copy(data, newData, length);
        data = newData;
        capacity = newCapacity;
    }

    public void Append(int value)
    {
        if (length == capacity)
        {
            Resize();
        }
        data[length] = value;
        length++;
    }

    public int Get(int index)
    {
        if (index >= 0 && index < length)
        {
            return data[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Індекс поза межами");
        }
    }

    public void Remove(int value)
    {
        int[] newData = new int[capacity];
        int j = 0;
        for (int i = 0; i < length; i++)
        {
            if (data[i] != value)
            {
                newData[j] = data[i];
                j++;
            }
        }
        data = newData;
        length = j;
        if (length < capacity / 2)
        {
            Resize();
        }
    }

    public void Insert(int index, int value)
    {
        if (length == capacity)
        {
            Resize();
        }
        for (int i = length; i > index; i--)
        {
            data[i] = data[i - 1];
        }
        data[index] = value;
        length++;
    }

    public void Clear()
    {
        data = new int[capacity];
        length = 0;
    }

    public override string ToString()
    {
        if (data != null)
        {
            return " [" + string.Join(", ", data.Take(length)) + "]";
        }
        else
        {
            return "Список після операції: []";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();

        for (int i = 0; i < 15; i++)
        {
            if (i % 2 == 0)
            {
                arrayList.Append(i);
            }
        }

        arrayList.Insert(4, 20);
        Console.WriteLine("Список пiсля додавання: " + arrayList);
        arrayList.Remove(5);
        arrayList.Remove(13);
        Console.WriteLine("Список пiсля видалення: " + arrayList);

        arrayList.Insert(3, 99);
        Console.WriteLine("Список пiсля вставки: " + arrayList);
        arrayList.Clear();
        Console.WriteLine("Список пiсля очищення: " + arrayList);
    }
}
