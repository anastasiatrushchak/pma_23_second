namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            NewsAgency agency1 = new NewsAgency("First News Agency");
            weatherStation.Attach(agency1);
            
            NewsAgency agency2 = new NewsAgency("Second News Agency");
            weatherStation.Attach(agency2);

            weatherStation.Temperature = 31.2f;
            weatherStation.Temperature = 28f;
            weatherStation.Temperature = 46.8f;
            weatherStation.Temperature = 15.3f;

            Console.ReadLine();
        }
    }
}




