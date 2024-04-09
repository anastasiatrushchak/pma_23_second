using System;
using System.IO;
using System.Linq;

public class ArrayList<T>
{
    private T[] array;
    private int size;
    private int defaultSize;

    public ArrayList(T[] inputArray = null, int defaultSize = 10)
    {
        this.defaultSize = defaultSize;
        array = new T[defaultSize];
        size = 0;

        if (inputArray != null)
        {
            if (inputArray.Length > defaultSize)
            {
                array = inputArray.Take(defaultSize).ToArray();
                size = defaultSize;
            }
            else
            {
                Array.Copy(inputArray, array, inputArray.Length);
                size = inputArray.Length;
            }
        }
        else
        {
            ReadFromFile(@"C:\Users\darko\Documents\array.txt");
        }
    }

    public override string ToString()
    {
        string[] elements = new string[size];
        for (int i = 0; i < size; i++)
        {
            elements[i] = array[i]?.ToString() ?? "None";
        }

        if (size < array.Length)
        {
            string[] remaining = new string[array.Length - size];
            Array.Fill(remaining, "None");
            return string.Join(", ", elements) + ", " + string.Join(", ", remaining);
        }
        else
        {
            return string.Join(", ", elements);
        }
    }

    public int Count => size;

    public void ReadFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] values = line.Trim().Split();
                if (values.Length == 2)
                {
                    int index = int.Parse(values[0]);
                    T element = (T)Convert.ChangeType(values[1], typeof(T));
                    Insert(index, element);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"file '{filename}' not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }

    public void Append(T element)
    {
        if (size == array.Length)
        {
            Resize();
        }
        array[size] = element;
        size++;
    }

    public void RemoveAt(int index)
    {
        if (index >= 0 && index < size)
        {
            T[] newArray = new T[array.Length];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, size - index - 1);
            array = newArray;
            size--;
        }
    }

    public void Remove(T element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            RemoveAt(index);
        }
    }




    public void Insert(int index, T element)
    {
        if (index < 0)
        {
            throw new NegativeIndexError("negative index is not allowed.");
        }
        if (index >= 0 && index <= size)
        {
            if (size == array.Length)
            {
                Resize();
            }
            for (int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = element;
            size++;
        }
    }

    public void Clear()
    {
        array = new T[10];
        size = 0;
    }

    private void Resize()
    {
        int newLength = (int)(1.5 * array.Length) + 1;
        T[] newArray = new T[newLength];
        Array.Copy(array, newArray, size);
        array = newArray;
    }

    public void SetDefaultSize(int newSize)
    {
        defaultSize = newSize;
        Resize();
    }

    // Ваші інші методи...

}
