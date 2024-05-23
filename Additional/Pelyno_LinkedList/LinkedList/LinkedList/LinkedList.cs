using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public int Count { get { return size; } }

        public LinkedList(IEnumerable<T> initialElements = null)
        {
            head = null;
            tail = null;
            size = 0;
            if (initialElements != null)
            {
                foreach (var element in initialElements)
                {
                    AddLast(element);
                }
            }
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
            size++;
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            size++;
        }

        public void AddAfter(Node<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentException("There is no this node");
            }

            Node<T> newNode = new Node<T>(value);
            newNode.Next = node.Next;
            newNode.Previous = node;
            if (node.Next != null)
            {
                node.Next.Previous = newNode;
            }
            else
            {
                tail = newNode;
            }
            node.Next = newNode;
            size++;
        }

        public void AddBefore(Node<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentException("There is no this node");
            }

            Node<T> newNode = new Node<T>(value);
            newNode.Previous = node.Previous;
            newNode.Next = node;
            if (node.Previous != null)
            {
                node.Previous.Next = newNode;
            }
            else
            {
                head = newNode;
            }
            node.Previous = newNode;
            size++;
        }

        public void Remove(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentException("There is no this node");
            }

            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }
            else
            {
                head = node.Next;
            }

            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }
            else
            {
                tail = node.Previous;
            }

            size--;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty");
            }

            head = head.Next;
            if (head != null)
            {
                head.Previous = null;
            }
            else
            {
                tail = null;
            }

            size--;
        }

        public void RemoveLast()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("List is empty");
            }

            tail = tail.Previous;
            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }

            size--;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public Node<T> Find(T value)
        {
            if (head == null)
            {
                throw new InvalidOperationException("List is empty");
            }

            Node<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                    return current;
                current = current.Next;
            }

            throw new ArgumentException("Node with this value not found");
        }
        public void Insert(int index, T value)
        {
            if (index < 0 || index > size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (index == 0)
            {
                AddFirst(value);
            }
            else if (index == size)
            {
                AddLast(value);
            }
            else
            {
                Node<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                Node<T> newNode = new Node<T>(value);
                newNode.Next = current.Next;
                newNode.Previous = current;
                current.Next.Previous = newNode;
                current.Next = newNode;

                size++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == size - 1)
            {
                RemoveLast();
            }
            else
            {
                Node<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;

                size--;
            }
        }

        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write("{0} ", current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
