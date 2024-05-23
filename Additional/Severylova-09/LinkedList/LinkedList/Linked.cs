using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{   public class Linked<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public Linked()
        {
            head = null;
            tail = null;
        }

        public void AppendToEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);
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
        }

        public void AppendToBegin(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                head.Previous = newNode;
                newNode.Next = head;
                head = newNode;
            }
        }

        public void AppendByIndex(T data, int index = 0)
        {

            try
            {
                if (index == 0)
                {
                    AppendToBegin(data);
                }
                else
                {
                    Node<T> newNode = new Node<T>(data);
                    Node<T> current = head;
                    int count = 0;
                    while (current != null && count < index - 1)
                    {
                        current = current.Next;
                        count++;
                    }
                    if (current == null)
                    {
                        Console.WriteLine("Index error");
                        return;
                    }

                    newNode.Next = current.Next;
                    newNode.Previous = current;
                    if (current.Next != null)
                    {
                        current.Next.Previous = newNode;
                    }
                    current.Next = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Remove()
        {
            if (tail != null)
            {
                if (tail.Previous != null)
                {
                    tail.Previous.Next = null;
                    tail = tail.Previous;
                }
                else
                {
                    head = null;
                    tail = null;
                }
            }
        }

        public void RemoveByIndex(int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Index error");
                return;
            }

            Node<T> current = head;
            for (int i = 0; i < index && current != null; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Index error");
                return;
            }

            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                head = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                tail = current.Previous;
            }
        }

        public override string ToString()
        {
            List<T> dataList = new List<T>();
            Node<T> current = head;
            while (current != null)
            {
                dataList.Add(current.Data);
                current = current.Next;
            }
            return string.Join(", ", dataList);
        }
    }
}
