using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_7;

public class MyLinkedList<T>
{
    private Node<T> _first;
    private Node<T> _last;
    private int _count;

    public int Count { get { return _count; } }
    public Node<T> First { get { return _first; } }
    public Node<T> Last { get { return _last; } }

    public MyLinkedList()
    {
        _first = null;
        _last = null;
        _count = 0;
    }

    public MyLinkedList(IEnumerable<T> values)
    {
        foreach (T value in values)
        {
            AddLast(value);
        }
    }

    public T GetValue(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException("Error! MyLinkedList.GetValue(int) index out of range!");
        }
        Node<T> currentNode = _first;
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.Next;
        }

        return currentNode.Value;
    }
    
    public void AddLast(T value)
    {
        Node<T> newNode = new Node<T>(_last, value, _first);
        if (_count == 0)
        {
            _first = newNode;
            _last = newNode;
            newNode.Next = newNode;
            newNode.Previous = newNode;
        }
        else
        {
            _last.Next = newNode;
            _first.Previous = newNode;
            _last = newNode;
        }
        _count++;
    }

    public void AddFirst(T value)
    {
        Node<T> newNode = new Node<T>(_last, value, _first);
        if (_count == 0)
        {
            _first = newNode;
            _last = newNode;
            newNode.Next = newNode;
            newNode.Previous = newNode;
        }
        else
        {
            newNode.Next = _first;
            newNode.Previous = _last;
            _first.Previous = newNode;
            _last.Next = newNode;
            _first = newNode;
        }
        _count++;
    }

    public void Insert(int index, T value)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException("Error! MyLinkedList.Insert(int, T) index out of range!");
        }

        if (index == 0)
        {
            AddFirst(value);
        }
        else if (index == _count)
        {
            AddLast(value);
        }
        else
        {
            Node<T> currentNode = _first;
            for (int i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.Next;
            }
            Node<T> newNode = new Node<T>(currentNode, value, currentNode.Next);
            currentNode.Next.Previous = newNode;
            currentNode.Next = newNode;
            _count++;
        }
    }

    public void Clear()
    {
        _first = null;
        _last = null;
        _count = 0;
    }

    public bool Contains(T item)
    {
        Node<T> currentNode = _first;
        for (int i = 0; i < _count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Value, item))
            {
                return true;
            }
            currentNode = currentNode.Next;
        }
        return false;
    }

    public void Remove(T item)
    {
        Node<T> currentNode = _first;
        for (int i = 0; i < _count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Value, item))
            {
                RemoveAt(i);
                return;
            }
            currentNode = currentNode.Next;
        }
        throw new InvalidOperationException("Item not found in the list");
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException("Error! MyLinkedList.RemoveAt(int) index out of range!");
        }

        if (_count == 1)
        {
            _first = null;
            _last = null;
        }
        else if (index == 0)
        {
            _first.Next.Previous = _last;
            _last.Next = _first.Next;
            _first = _first.Next;
        }
        else if (index == _count - 1)
        {
            _last.Previous.Next = _first;
            _first.Previous = _last.Previous;
            _last = _last.Previous;
        }
        else
        {
            Node<T> currentNode = _first;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Previous.Next = currentNode.Next;
            currentNode.Next.Previous = currentNode.Previous;
        }
        _count--;
    }

    public override string ToString()
    {
        string toString = "";

        Node<T> currentNode = _first;
        for (int i = 0; i < _count; i++)
        {
            toString += $"({currentNode.Previous.Value}, {currentNode.Value}, {currentNode.Next.Value}) ";
            currentNode = currentNode.Next;
        }

        return toString;
    }
}


