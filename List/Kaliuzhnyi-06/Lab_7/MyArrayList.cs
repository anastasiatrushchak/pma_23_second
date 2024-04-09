using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_7;

public class MyArrayList<T>
{
    private T[] _array = [];

    public int Count { get; private set; }
    public int Capacity {  get { return _array.Length; } }

    public MyArrayList()
    {
        Count = 0;
    }

    public MyArrayList(int capacity)
    {
        if(capacity <= 0)
        {
            throw new ArgumentException("Error! Capacity can't be equal or less than 0!");
        }

        Count = 0;
        _array = new T[capacity];
    }

    public MyArrayList(ICollection<T> collection)
    {
        Count = 0;
        AddRange(collection);
    }

    private void GrowCapacity()
    {
        T[] newArray = _array;
        _array = new T[(int)(Capacity*1.5+1)];
        for(int i = 0; i < Count; i++)
        {
            _array[i] = newArray[i];
        }
    }

    public T GetValue(int index)
    {
        if (index >= Count || index < 0)
        {
            throw new IndexOutOfRangeException("Error! MyArrayList.GetValue(int) index out of range!");
        }
     
        return _array[index];
    }

    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("Error! MyArrayList.Add(T) nullable argument value!");
        }

        if (Capacity == Count)
        {
            GrowCapacity();
        }
        _array[Count] = item;
        Count++;
    }

    public void AddRange(ICollection<T> collection)
    {
        if (collection == null)
        {
            throw new ArgumentNullException("Error! MyArrayList.AddRange(ICollection<T>) nullable argument value!");
        }
        foreach(T item in collection)
        {
            Add(item);
        }
    }

    public void Insert(int index, T element)
    {
        if (element == null)
        {
            throw new ArgumentNullException("Error! MyArrayList.Insert(int, T) nullable argument value!");
        }
        if (index >= Count || index < 0)
        {
            throw new IndexOutOfRangeException("Error! MyArrayList.Insert(int, T) index out of range!");
        }
        if(Count == Capacity)
        {
            GrowCapacity();
        }
        for(int i = Count; i > index ;i--)
        {
            _array[i] = _array[i - 1];
        }
        _array[index] = element;
        Count++;
    }

    public void Clear()
    {
        _array = [];
        Count = 0;
    }

    public void Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("Error! MyArrayList.Remove(T) nullable argument value!");
        }
        for (int i = 0; i < Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(_array[i], item))
            {
                RemoveAt(i);
                return;
            }
        }
        throw new ArgumentException("Error! There is no element to remove!");
    }

    public void RemoveAt(int index)
    {
        if (index >= Count || index < 0)
        {
            throw new IndexOutOfRangeException("MyArrayList.RemoveAt(int) index out of range!");
        }
        for (int i = index; i < Count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }
        Count--;
    }

    public bool Contains(T item)
    {
        if(item  == null)
        {
            throw new ArgumentNullException("Error! MyArrayList.Contains(T) nullable argument value!");
        }
        for (int i = 0; i < Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(_array[i], item))
            {
                return true;
            }
        }

        return false;
    }

    public override string ToString()
    {
        string toString = "";
        for (int i = 0; i < Count; i++)
        {
            toString += _array[i].ToString();
            toString += " ";
        }
        for (int i = Count; i < Capacity; i++)
        {
            toString += "null ";
        }
        toString += " Cap = " + Capacity + " Count = " + Count;

        return toString;
    }

}
