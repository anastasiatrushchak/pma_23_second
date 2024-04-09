using System;

namespace LinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
            this.Prev = null;
        }
    }
}