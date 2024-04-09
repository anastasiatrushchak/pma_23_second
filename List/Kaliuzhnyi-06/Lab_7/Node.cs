using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7;

public class Node<T>
{
    public Node<T> Previous { get; set; }
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(Node<T> prev, T value, Node<T> next)
    {
        Previous = prev;
        Value = value;
        Next = next;
    }
}
