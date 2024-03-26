public class TextEditor
{
    private string _text = "";

    public void Type(string text)
    {
        _text += text;
    }

    public string GetText()
    {
        return _text;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(_text);
    }

    public void Restore(EditorMemento memento)
    {
        _text = memento.Text;
    }
}