namespace Prototype;

public abstract class Person
{
    protected Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public abstract Person Clone();
}