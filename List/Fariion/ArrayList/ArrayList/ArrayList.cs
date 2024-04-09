using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList;
public class ArrayList<T>
{
    private int capacity;
    private int size;
    private T[] data;

    public ArrayList(int n)
    {
        capacity = n;
        size = 0;
        data = new T[capacity];
        
    }

    public void Add(T element)
    {
        if (size >= capacity)
        {
            Resize();
        }
        data[size] = element;
        size++;
    }

    public void Remove(int index)
    {
        try
        {
            if (index >= 0 && index < size)
            {
                for (int i = index; i < size - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                data[size - 1] = default(T);
                size--;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid remove index");
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Removal error: {e.Message}");
        }
    }

    public void Insert(int index, T element)
    {
        if (size >= capacity)
        {
            Resize();
        }
        try
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Invalid insert index");
            }

            for (int i = size; i > index; i--)
            {
                data[i] = data[i - 1];
            }
            data[index] = element;
            size++;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Insertion error: {e.Message}");
        }
    }

    public void Clear()
    {
        data = new T[capacity];
        size = 0;
    }

    public int Count
    {
        get { return size; }
    }

    public override string ToString()
    {
        return "[" + string.Join(",", data[..size]) + "]";
    }

    private void Resize()
    {
        capacity = (int)(1.5 * capacity) + 1;
        T[] newData = new T[capacity];
        Array.Copy(data, newData, size);
        data = newData;
    }
}
