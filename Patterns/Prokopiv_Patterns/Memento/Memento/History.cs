public class History
{
    private readonly Stack<EditorMemento> _mementos = new Stack<EditorMemento>();

    public void Push(EditorMemento memento)
    {
        _mementos.Push(memento);
    }

    public EditorMemento Pop()
    {
        return _mementos.Pop();
    }
}