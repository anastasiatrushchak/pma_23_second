using System;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T data;
            public Node prev;
            public Node next;

            public Node(T data)
            {
                this.data = data;
                prev = null;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        private int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Size
        {
            get { return size; }
        }


        public void Add(T data)
        {
            Node newNode = new Node(data);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            size++;
        }
        public void AddByIndex(int index, T data)
        {
            if (index < 0 || index > size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");
            }

            Node newNode = new Node(data);
            if (index == 0)
            {
                newNode.next = head;
                if (head != null)
                    head.prev = newNode;
                head = newNode;
                if (tail == null)
                    tail = newNode;
            }
            else if (index == size)
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                newNode.prev = current;
                current.next.prev = newNode;
                current.next = newNode;
            }
            size++;
        }


        public void Remove(T data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data.Equals(data))
                {
                    if (current == head)
                    {
                        head = head.next;
                        if (head != null)
                            head.prev = null;
                        else
                            tail = null;
                        size--;
                        return;
                    }
                    else if (current == tail)
                    {
                        tail = tail.prev;
                        tail.next = null;
                        size--;
                        return;
                    }
                    else
                    {
                        current.prev.next = current.next;
                        current.next.prev = current.prev;
                        size--;
                        return;
                    }
                }
                current = current.next;
            }
            throw new InvalidOperationException("Element is not found in list");
        }

        public void RemoveByIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }

            if (current == head)
            {
                head = head.next;
                if (head != null)
                    head.prev = null;
                else
                    tail = null;
            }
            else if (current == tail)
            {
                tail = tail.prev;
                tail.next = null;
            }
            else
            {
                current.prev.next = current.next;
                current.next.prev = current.prev;
            }
            size--;
        }


        public void Write()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

}
