using System;

class HelpCenter
{
    public string RequestType { get; set; }

    public HelpCenter(string requestType)
    {
        RequestType = requestType;
    }
}


abstract class Handler
{
    public Handler next;

    public void SetNext(Handler next)
    {
        this.next = next;
    }

    public abstract void HandleRequest(HelpCenter request);
}


class GasService : Handler
{
    public override void HandleRequest(HelpCenter request)
    {
        if (request.RequestType == "GasEmergency")
        {
            Console.WriteLine("Gas Service is handling the request.");
        }
        else if (next != null)
        {
            next.HandleRequest(request);
        }
    }
}


class FireService : Handler
{
    public override void HandleRequest(HelpCenter request)
    {
        if (request.RequestType == "FireEmergency")
        {
            Console.WriteLine("Fire Service is handling the request.");
        }
        else if (next != null)
        {
            next.HandleRequest(request);
        }
    }
}


class PoliceService : Handler
{
    public override void HandleRequest(HelpCenter request)
    {
        if (request.RequestType == "PoliceEmergency")
        {
            Console.WriteLine("Police Service is handling the request.");
        }
        else if (next != null)
        {
            next.HandleRequest(request);
        }
    }
}


class MedicalService : Handler
{
    public override void HandleRequest(HelpCenter request)
    {
        if (request.RequestType == "MedicalEmergency")
        {
            Console.WriteLine("Medical Service is handling the request.");
        }
        else if (next != null)
        {
            next.HandleRequest(request);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Handler gasService = new GasService();
        Handler fireService = new FireService();
        Handler police = new PoliceService();
        Handler medicalEmergency = new MedicalService();

        
        gasService.SetNext(medicalEmergency);
        medicalEmergency.SetNext(fireService);
        fireService.SetNext(police);

        
        HelpCenter request1 = new HelpCenter("GasEmergency");
        HelpCenter request2 = new HelpCenter("MedicalEmergency");
        HelpCenter request3 = new HelpCenter("FireEmergency");
        HelpCenter request4 = new HelpCenter("PoliceEmergency");

        
        gasService.HandleRequest(request1);
        gasService.HandleRequest(request4);
        gasService.HandleRequest(request2);
        gasService.HandleRequest(request3);
    }
}
