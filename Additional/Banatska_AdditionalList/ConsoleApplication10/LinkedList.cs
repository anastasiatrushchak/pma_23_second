using System;

namespace ConsoleApplication10
{
    public class LinkedList<T>
    {
        private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public LinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void AddLast(T data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    public void Delete(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        Node current = head;
        Node previous = null;
        int currentIndex = 0;

        while (current != null && currentIndex < index)
        {
            previous = current;
            current = current.Next;
            currentIndex++;
        }

        if (current != null)
        {
            if (previous != null)
            {
                previous.Next = current.Next;
                if (current.Next == null)
                {
                    tail = previous;
                }
            }
            else
            {
                head = current.Next;
                if (head == null)
                {
                    tail = null;
                }
            }
            count--;
        }
    }

    public void Insert(T data, int position)
    {
        if (position < 0 || position > count)
        {
            throw new ArgumentOutOfRangeException(nameof(position), "Invalid position");
        }

        Node newNode = new Node(data);

        if (position == 0)
        {
            newNode.Next = head;
            head = newNode;
            if (tail == null)
            {
                tail = head;
            }
        }
        else
        {
            Node current = head;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            if (newNode.Next == null)
            {
                tail = newNode;
            }
        }
        count++;
    }

    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
    }
}