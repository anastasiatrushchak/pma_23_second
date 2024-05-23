using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList;
public class LinkedList<T>
{
    private List<Node<T>> _list;

    public LinkedList(List<T> arr)
    {
        _list = new List<Node<T>>();
        foreach (T item in arr)
        {
            _list.Add(new Node<T>(item));
        }
        SetNodes();
    }

    public LinkedList() : this(new List<T>()) { }

    private void SetNodes()
    {
        int last = _list.Count - 1;
        for (int i = 0; i < _list.Count; i++)
        {
            if (i == 0)
            {
                _list[i].Previous = null;
            }
            else
            {
                _list[i].Previous = _list[i - 1];
            }

            if (i == last)
            {
                _list[i].Next = null;
            }
            else
            {
                _list[i].Next = _list[i + 1];
            }
        }
    }

    public void Remove(int index)
    {
        try
        {
            _list.RemoveAt(index);
            SetNodes();
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Index out of bounds for removal.");
        }
    }

    public void Append(T value)
    {
        Node<T> temp = new Node<T>(value);
        _list.Add(temp);
        SetNodes();
    }

    public void Insert(int index, T value)
    {
        try
        {
            if (index < 0 || index > _list.Count)
            {
                throw new ArgumentOutOfRangeException("Wrong insert index!");
            }
            else
            {
                Node<T> temp = new Node<T>(value);
                _list.Insert(index, temp);
                SetNodes();
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Clear(int index)
    {
        try
        {
            _list[index].Value = default(T);
            SetNodes();
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Index out of bounds for clearing.");
        }
    }

    public void ClearList()
    {
        _list.Clear();
    }

    public override string ToString()
    {
        if (_list.Count == 0)
        {
            return "Empty Linked list";
        }
        else
        {
            string result = "Linked list: ";
            foreach (Node<T> node in _list)
            {
                result += node.Value.ToString() + ", ";
            }
            return result.TrimEnd(' ', ',');
        }
    }
}