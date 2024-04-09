using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked
{
    public class LinkedList<T>
    {
        private Node<T> head;

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);

            try
            {
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while appending node: {ex.Message}");
            }
        }

        public void Insert(int index, T data)
        {
            try
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index must be non-negative.");
                }

                Node<T> newNode = new Node<T>(data);

                if (index == 0)
                {
                    newNode.Next = head;
                    head = newNode;
                    return;
                }

                Node<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    if (current == null)
                    {
                        throw new ArgumentOutOfRangeException("Index is out of range.");
                    }
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while inserting node: {ex.Message}");
            }
        }

        public void Remove(int index)
        {
            try
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index must be non-negative.");
                }

                if (index == 0)
                {
                    if (head != null)
                    {
                        head = head.Next;
                        return;
                    }
                    else
                    {
                        throw new InvalidOperationException("List is empty.");
                    }
                }

                Node<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    if (current == null || current.Next == null)
                    {
                        throw new ArgumentOutOfRangeException("Index is out of range.");
                    }
                    current = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while removing node: {ex.Message}");
            }
        }

        public void Display()
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
}
