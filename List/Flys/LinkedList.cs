using LinkedList;
using System;
using System.Collections.Generic;

public class LinkedList<T>
{
    public Node<T> Head { get; set; }

    public LinkedList(List<T> nodes)
    {
        this.Head = null;
        if (nodes != null && nodes.Count > 0)
        {
            Node<T> node = new Node<T>(nodes[0]);
            this.Head = node;
            for (int i = 1; i < nodes.Count; i++)
            {
                node.Next = new Node<T>(nodes[i]);
                node.Next.Prev = node;
                node = node.Next;
            }
        }
    }

    public void Append(T data)
    {
        if (this.Head == null)
        {
            this.Head = new Node<T>(data);
        }
        else
        {
            Node<T> node = this.Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            Node<T> newNode = new Node<T>(data);
            node.Next = newNode;
            newNode.Prev = node;
        }
    }

    public void Remove(T data)
    {
        Node<T> node = this.Head;
        while (node != null)
        {
            if (node.Data.Equals(data))
            {
                if (node.Prev != null)
                {
                    node.Prev.Next = node.Next;
                }
                else
                {
                    this.Head = node.Next;
                }
                if (node.Next != null)
                {
                    node.Next.Prev = node.Prev;
                }
                return;
            }
            node = node.Next;
        }
        throw new ArgumentException("Елемент не знайдено в списку");
    }

    public void Insert(int index, T data)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Введіть невід'ємний індекс!");
        }
        else if (index == 0)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = this.Head;
            if (this.Head != null)
            {
                this.Head.Prev = newNode;
            }
            this.Head = newNode;
        }
        else
        {
            Node<T> node = this.Head;
            for (int i = 0; i < index - 1; i++)
            {
                if (node == null)
                {
                    throw new IndexOutOfRangeException("Невірний індекс");
                }
                node = node.Next;
            }
            if (node == null)
            {
                throw new IndexOutOfRangeException("Невірний індекс");
            }
            Node<T> newNode = new Node<T>(data);
            newNode.Next = node.Next;
            newNode.Prev = node;
            if (node.Next != null)
            {
                node.Next.Prev = newNode;
            }
            node.Next = newNode;
        }
    }

    public void Clear()
    {
        this.Head = null;
    }

    public List<T> Display()
    {
        List<T> elements = new List<T>();
        Node<T> node = this.Head;
        while (node != null)
        {
            elements.Add(node.Data);
            node = node.Next;
        }
        return elements;
    }
}
