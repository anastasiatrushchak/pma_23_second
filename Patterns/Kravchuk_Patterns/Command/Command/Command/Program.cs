using System;
using System.Windows.Input;

public interface ICommand
{
    void Act();
}

public class BookAppointmentCommand : ICommand
{
    private readonly AppointmentScheduler _scheduler;

    public BookAppointmentCommand(AppointmentScheduler scheduler)
    {
        _scheduler = scheduler;
    }

    public void Act()
    {
        _scheduler.BookAppointment();
    }
}

public class PerformServiceCommand : ICommand
{
    private readonly BeautyService _service;

    public PerformServiceCommand(BeautyService service)
    {
        _service = service;
    }

    public void Act()
    {
        _service.Perform();
    }
}


public class AppointmentScheduler
{
    public void BookAppointment()
    {
        Console.WriteLine("Клієнт записаний на процедуру.");
    }
}


public class BeautyService
{
    public void Perform()
    {
        Console.WriteLine("Послуга виконана.");
    }
}

public class SalonManager
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Act();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        AppointmentScheduler scheduler = new AppointmentScheduler();
        BeautyService service = new BeautyService();

        ICommand bookCommand = new BookAppointmentCommand(scheduler);
        ICommand performCommand = new PerformServiceCommand(service);

       
        SalonManager salonManager = new SalonManager();
        salonManager.SetCommand(bookCommand);

     
        salonManager.ExecuteCommand();

        
        salonManager.SetCommand(performCommand);
        salonManager.ExecuteCommand();
    }
}
