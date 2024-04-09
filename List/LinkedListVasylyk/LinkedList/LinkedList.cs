namespace LinkedList;

public class CustomLinkedList<T>
{
    private Node<T> first;

    public CustomLinkedList(Node<T> first)
    {
        this.first = first;
    }

    public void AddAtEnd(T value)
    {
        Node<T> current = first;
        while (current.HasNext())
        {
            current = current.NextNode;
        }
        current.NextNode = new Node<T>(value, current, null);
    }

    public void AddAtBegin(T value)
    {
        Node<T> newNode = new Node<T>(value, null, first);
        first.PrevNode = newNode;
        first = newNode;
    }

    public void AddByIndex(int index, T value)
    {
        int i = 0;
        Node<T> current = first;
        while (current.HasNext() && i < index)
        {
            i++;
            current = current.NextNode;
        }
        if (i == index)
        {
            Node<T> newNode = new Node<T>(value, current.PrevNode, current);
            current.PrevNode.NextNode = newNode;
            current.PrevNode = newNode;
        }
    }
    public void Remove(T value)
    {
        Node<T> current = first;
        while (current != null)
        {
            if (current.Value.Equals(value))
            {
                if (current.PrevNode != null)
                {
                    current.PrevNode.NextNode = current.NextNode;
                }
                else
                {
                    first = current.NextNode;
                }

                if (current.NextNode != null)
                {
                    current.NextNode.PrevNode = current.PrevNode;
                }
                return;
            }
            current = current.NextNode;
        }
    }

    public override string ToString()
    {
        Node<T> current = first;
        string output = current.Value + " ";
        while (current.HasNext())
        {
            current = current.NextNode;
            output += current.Value + " ";
        }
        return output;
    }
}