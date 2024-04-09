using System;
using System.Collections.Generic;

public class Node
{
    public object ThisItem { get; set; }
    public Node NextItem { get; set; }
    public Node PreviousItem { get; set; }

    public Node(object value)
    {
        ThisItem = value;
        NextItem = null;
        PreviousItem = null;
    }
}

public class LinkedList
{
    private List<Node> _list;

    public LinkedList()
    {
        _list = new List<Node>();
    }

    public int Count => _list.Count;

    public override string ToString()
    {
        if (Count == 0)
            return "Empty Linked list";

        string result = ": ";
        foreach (var node in _list)
        {
            result += node.ThisItem + ", ";
        }
        return result.Substring(0, result.Length - 2);
    }

    public void Delete(int index)
    {
        try
        {
            if (index < 0)
                index = Count + index;
            if (index >= 0 && index < Count)
            {
                _list.RemoveAt(index);
                SetNodes();
            }
            else
            {
                Console.WriteLine("Index out of range. Cannot delete element.");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range. Cannot delete element.");
        }
    }

    public void Add(object value)
    {
        Node node = new Node(value);
        _list.Add(node);
        SetNodes();
    }

    public void Insert(int index, object value)
    {
        try
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException();

            Node node = new Node(value);
            _list.Insert(index, node);
            SetNodes();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Wrong insert index!");
        }
    }

    public void ClearElement(int index)
    {
        try
        {
            if (index < 0)
                index = Count + index;
            if (index >= 0 && index < Count)
            {
                _list[index].ThisItem = null;
                SetNodes();
            }
            else
            {
                Console.WriteLine("Index out of range. Cannot clear element.");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range. Cannot clear element.");
        }
    }

    public void Clear()
    {
        _list.Clear();
    }

    private void SetNodes()
    {
        int length = Count;
        for (int i = 0; i < length; i++)
        {
            _list[i].PreviousItem = (i > 0) ? _list[i - 1] : null;
            _list[i].NextItem = (i < length - 1) ? _list[i + 1] : null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList my_list = new LinkedList();
        my_list.Add(42);
        my_list.Add(88);
        my_list.Add(123);
        my_list.Add(555);
        my_list.Add(77);
        my_list.Add(99);
        my_list.Add(789);
        Console.WriteLine("Linked List: " + my_list);
        my_list.ClearElement(3);
        Console.WriteLine("After clear 3 element: " + my_list);
        my_list.Delete(1);
        Console.WriteLine("After delete 1 element: " + my_list);
        my_list.Insert(5, 1001);
        Console.WriteLine("After inserting element 1001 at index 5: " + my_list);
    }
}
