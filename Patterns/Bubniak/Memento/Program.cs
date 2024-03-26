using System;

class Originator
{
    private string state;

    public string State
    {
        get { return state; }
        set
        {
            Console.WriteLine("Originator: Setting state to " + value);
            state = value;
        }
    }

    public Memento Save()
    {
        Console.WriteLine("Originator: Saving state to Memento");
        return new Memento(state);
    }

    public void Restore(Memento memento)
    {
        state = memento.State;
        Console.WriteLine("Originator: Restoring state from Memento: " + state);
    }
}

class Memento
{
    public string State { get; }

    public Memento(string state)
    {
        State = state;
    }
}

class Caretaker
{
    public Memento Memento { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker();

        originator.State = "State1";
        caretaker.Memento = originator.Save();

        originator.State = "State2";

        originator.Restore(caretaker.Memento);
    }
}
