using System;

namespace LinkedList
{
    internal class LinkedList<T>
    {
        private Node<T> head = null;

        public void Add(T data)
        {
            Node<T> n = new Node<T>(data, head);
            head = n;
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                Add(data);
                return;
            }

            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            Node<T> n = new Node<T>(data, current.Next);
            current.Next = n;
        }

        public void AddAtIndex(int index, T data)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative.");

            if (index == 0)
            {
                Add(data);
                return;
            }

            Node<T> current = head;
            Node<T> previous = null;
            int currentIndex = 0;

            while (current != null && currentIndex < index)
            {
                previous = current;
                current = current.Next;
                currentIndex++;
            }

            if (currentIndex == index)
            {
                Node<T> newNode = new Node<T>(data, current);
                previous.Next = newNode;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
        }

        public T Get()
        {
            if (head != null)
                return head.Data;
            else
                throw new Exception("List is empty");
        }

        public T GetLast()
        {
            if (head == null)
            {
                throw new Exception("List is empty");
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                return current.Data;
            }
        }

        public void Remove()
        {
            head = head.Next;
        }

        public void RemoveLast()
        {
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node<T> current = head;
                Node<T> previous = null;
                while (current.Next != null)
                {
                    previous = current;
                    current = current.Next;
                }
                previous.Next = current.Next;
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative.");

            if (index == 0)
            {
                Remove();
                return;
            }

            Node<T> current = head;
            Node<T> previous = null;
            int currentIndex = 0;

            while (current != null && currentIndex < index)
            {
                previous = current;
                current = current.Next;
                currentIndex++;
            }

            if (currentIndex == index)
            {
                previous.Next = current.Next;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
        }

        public void Print()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write("{0} ", current.Data);
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
