namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        Node<int> node1 = new Node<int>(10, null, null);
        
        CustomLinkedList<int> linkedList = new CustomLinkedList<int>(node1);

        linkedList.AddAtEnd(7);
        linkedList.AddAtBegin(10);
        linkedList.AddAtEnd(5);
        linkedList.AddAtEnd(2);
        linkedList.AddAtBegin(0);

        Console.WriteLine(linkedList);
        linkedList.Remove(5);
        Console.WriteLine(linkedList);
        linkedList.Remove(10);
        Console.WriteLine(linkedList);
        linkedList.Remove(0);
        Console.WriteLine(linkedList);
        linkedList.AddByIndex(1, 100);
        Console.WriteLine(linkedList);
    }
}
