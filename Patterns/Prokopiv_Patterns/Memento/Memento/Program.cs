using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        History history = new History();

        editor.Type("Hello, ");
        history.Push(editor.Save());

        editor.Type("world!");
        history.Push(editor.Save());

        Console.WriteLine(editor.GetText()); 

        editor.Restore(history.Pop());
        Console.WriteLine(editor.GetText()); 

        editor.Restore(history.Pop());
        Console.WriteLine(editor.GetText()); 
    }
}
