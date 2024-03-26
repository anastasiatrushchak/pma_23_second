using System;
using System.Collections.Generic;

// Mediator interface
interface IMediator
{
    void Notify(object sender, string ev);
}

// Concrete Mediator
class ConcreteMediator : IMediator
{
    private List<Component> _components = new List<Component>();

    public void Register(Component component)
    {
        _components.Add(component);
        component.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        foreach (var component in _components)
        {
            if (component != sender)
                component.Receive(ev);
        }
    }
}

// Base Component
abstract class Component
{
    protected IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Send(string ev);
    public abstract void Receive(string ev);
}

// Concrete Component
class ConcreteComponent : Component
{
    public override void Send(string ev)
    {
        Console.WriteLine("Component sends: " + ev);
        _mediator.Notify(this, ev);
    }

    public override void Receive(string ev)
    {
        Console.WriteLine("Component receives: " + ev);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Client code
        ConcreteMediator mediator = new ConcreteMediator();
        ConcreteComponent component1 = new ConcreteComponent();
        ConcreteComponent component2 = new ConcreteComponent();

        mediator.Register(component1);
        mediator.Register(component2);

        component1.Send("Hello from component1");
        component2.Send("Hello from component2");
    }
}
