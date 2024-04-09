using System;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T> head;

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.Next = head;
        head = newNode;
    }

    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node<T> current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public void Print()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myList = new LinkedList<int>();
        myList.AddLast(1);
        myList.AddLast(2);
        myList.AddLast(3);
        myList.AddFirst(0);
        myList.Print();
    }
}
