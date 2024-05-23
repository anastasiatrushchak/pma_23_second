using System;
using System.Collections.Generic;

public class LinkedList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public LinkedList(List<T> values = null)
    {
        head = null;
        tail = null;
        if (values != null)
        {
            foreach (T value in values)
            {
                Append(value);
            }
        }
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public void Append(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (IsEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else if (Comparer<T>.Default.Compare(data, head.Data) < 0)
        {
            newNode.NextNode = head;
            head.PrevNode = newNode;
            head = newNode;
        }
        else
        {
            Node<T> currentNode = head;
            while (currentNode.NextNode != null && Comparer<T>.Default.Compare(data, currentNode.NextNode.Data) > 0)
            {
                currentNode = currentNode.NextNode;
            }

            if (currentNode.NextNode != null)
            {
                newNode.NextNode = currentNode.NextNode;
                currentNode.NextNode.PrevNode = newNode;
            }
            else
            {
                tail = newNode;
            }

            newNode.PrevNode = currentNode;
            currentNode.NextNode = newNode;
        }
    }

    public void Prepend(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (IsEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.NextNode = head;
            head.PrevNode = newNode;
            head = newNode;
        }
    }

    public void InsertAtEnd(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (IsEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.PrevNode = tail;
            tail.NextNode = newNode;
            tail = newNode;
        }
    }

    public bool Delete(T data)
    {
        Node<T> currentNode = head;
        while (currentNode != null)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Data, data))
            {
                if (currentNode.PrevNode != null)
                {
                    currentNode.PrevNode.NextNode = currentNode.NextNode;
                }
                else
                {
                    head = currentNode.NextNode;
                }

                if (currentNode.NextNode != null)
                {
                    currentNode.NextNode.PrevNode = currentNode.PrevNode;
                }
                else
                {
                    tail = currentNode.PrevNode;
                }

                return true;
            }
            currentNode = currentNode.NextNode;
        }

        Console.WriteLine($"Помилка: Елемент {data} не знайдено у списку");
        Environment.Exit(1);
        return false;
    }

    public void AppendAt(T data, int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Індекс повинен бути не менше 0.");
        }

        if (index == 0)
        {
            Prepend(data);
            return;
        }

        int currentIndex = 0;
        Node<T> currentNode = head;
        while (currentNode != null && currentIndex < index - 1)
        {
            currentNode = currentNode.NextNode;
            currentIndex++;
        }

        if (currentNode == null)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Індекс виходить за межі списку.");
        }

        Node<T> newNode = new Node<T>(data);
        newNode.NextNode = currentNode.NextNode;
        newNode.PrevNode = currentNode;
        if (currentNode.NextNode != null)
        {
            currentNode.NextNode.PrevNode = newNode;
        }
        else
        {
            tail = newNode;
        }
        currentNode.NextNode = newNode;
    }

    public void DeleteAt(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Індекс повинен бути не менше 0.");
        }

        if (head == null)
        {
            throw new InvalidOperationException("Список порожній.");
        }

        if (index == 0)
        {
            head = head.NextNode;
            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.PrevNode = null;
            }
            return;
        }

        int currentIndex = 0;
        Node<T> currentNode = head;
        while (currentNode != null && currentIndex < index)
        {
            currentNode = currentNode.NextNode;
            currentIndex++;
        }

        if (currentNode == null)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Індекс виходить за межі списку.");
        }

        if (currentNode.NextNode != null)
        {
            currentNode.NextNode.PrevNode = currentNode.PrevNode;
        }
        else
        {
            tail = currentNode.PrevNode;
        }

        if (currentNode.PrevNode != null)
        {
            currentNode.PrevNode.NextNode = currentNode.NextNode;
        }
        else
        {
            head = currentNode.NextNode;
        }
    }

    public void Display()
    {
        List<T> elements = new List<T>();
        Node<T> currentNode = head;
        while (currentNode != null)
        {
            elements.Add(currentNode.Data);
            currentNode = currentNode.NextNode;
        }
        Console.WriteLine(string.Join(", ", elements));
    }

    class Node<U>
    {
        public U Data { get; set; }
        public Node<U> NextNode { get; set; }
        public Node<U> PrevNode { get; set; }

        public Node(U data)
        {
            Data = data;
            NextNode = null;
            PrevNode = null;
        }
    }

    
}
