namespace LinkedList;

public class Node<T>
{ 
    public T Value { get; set; }
    public Node<T>? PrevNode { get; set; }
    public Node<T>? NextNode { get; set; }

    public bool HasNext()
    {
        return NextNode != null;
    }

    public Node(T value, Node<T> prevNode, Node<T> nextNode)
    {
        Value = value;
        PrevNode = prevNode;
        NextNode = nextNode;
    }
}

