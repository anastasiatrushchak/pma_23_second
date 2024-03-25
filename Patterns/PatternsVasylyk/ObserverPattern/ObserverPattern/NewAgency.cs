namespace MyNamespace;

class NewsAgency : IObserver
{
    public String AgencyName { get; set; }

    public NewsAgency(String name)
    {
        AgencyName = name;
    }

    public void Update(ISubject subject)
    {
        if (subject is WeatherStation weatherStation)
        {
            Console.WriteLine(String.Format("{0} reporting temperature {1} degree celcius", AgencyName,
                weatherStation.Temperature));
            Console.WriteLine();
        }
    }
}