using System;

abstract class SupportHandler
{
    protected SupportHandler nextHandler;

    public void SetNextHandler(SupportHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(string request);
}

class AutoResponder : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "AutoResponder")
        {
            Console.WriteLine("Auto Responder: Thank you for contacting us. Your request has been received.");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine("Auto Responder: Unable to handle the request. Forwarding to the next handler.");
            nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("No suitable handler found.");
        }
    }
}

class Consultant : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Consultant Assistance")
        {
            Console.WriteLine("Consultant: Hello, how can I assist you?");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine("Consultant: Unable to handle the request. Forwarding to the next handler.");
            nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("No suitable handler found.");
        }
    }
}

class ChiefEngineer : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Chief Engineer Support")
        {
            Console.WriteLine("Chief Engineer: This is the Chief Engineer. How may I help you?");
        }
        else
        {
            Console.WriteLine("No suitable handler found.");
        }
    }
}

class Client
{
    private SupportHandler handlerChain;

    public Client(SupportHandler handlerChain)
    {
        this.handlerChain = handlerChain;
    }

    public void MakeRequest(string request)
    {
        handlerChain.HandleRequest(request);
    }
}

class Program
{
    static void Main(string[] args)
    {
        AutoResponder autoResponder = new AutoResponder();
        Consultant consultant = new Consultant();
        ChiefEngineer chiefEngineer = new ChiefEngineer();

        autoResponder.SetNextHandler(consultant);
        consultant.SetNextHandler(chiefEngineer);

        Client clientA = new Client(autoResponder);
        Client clientB = new Client(autoResponder);
        Client clientC = new Client(autoResponder);

        Console.WriteLine("Client C:");
        clientC.MakeRequest("AutoResponder");
        Console.WriteLine();


        Console.WriteLine("Client B:");
        clientB.MakeRequest("Consultant Assistance");
        Console.WriteLine();

        Console.WriteLine("Client A:");
        clientA.MakeRequest("Chief Engineer Support");

        Console.ReadLine();
    }
}
