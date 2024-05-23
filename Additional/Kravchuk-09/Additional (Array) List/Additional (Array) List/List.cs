using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional__Array__List;
public class ArrayList<T>
{
    private int Capacity;
    private int Size;
    private T[] elements;

    public ArrayList(int n)
    {
        Capacity = n;
        Size = 0;
        elements = new T[Capacity];

    }
    public void Print()
    {
        Console.WriteLine("Array List: " + ToString());
    }

    public void AddElement(T element)
    {
        if (Size >= Capacity)
        {
            Resize();
        }
        elements [Size] = element;
        Size++;
    }

    public void RemoveElement(int index)
    {
        try
        {
            if (index >= 0 && index < Size) // Перевіряємо валідність індексу
            {
                for (int i = index; i < Size - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }
                elements[Size - 1] = default(T);
                Size--;
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
    public void Clear()
    {
        elements = new T[Capacity];
        Size = 0;
    }

    public int Count
    {
        get { return Size; }
    }

    public override string ToString()
    {
        return "[" + string.Join(",", elements[..Size]) + "]";
    }

    private void Resize()
    {
        Capacity = (int)(1.5 * Capacity) + 1;
        T[] newData = new T[Capacity];
        Array.Copy(elements, newData, Size);
        elements = newData;
    }

    public void InsertElement(int index, T element)
    {
        if (Size >= Capacity)
        {
            Resize();
        }
        try
        {
            if (index < 0 || index > Size)
            {
                throw new IndexOutOfRangeException("Invalid insert index");
            }

            for (int i = Size; i > index; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[index] = element;
            Size++;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Insertion error: {e.Message}");
        }
    }


}