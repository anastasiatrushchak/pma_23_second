using System;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string json = File.ReadAllText("file1.json");

            var jObject = JObject.Parse(json);// Парсимо рядок JSON у об'єкт 

            var formattedJson = JToken.FromObject(jObject);//форматування

            var xml = JsonConvert.DeserializeXmlNode(formattedJson.ToString(), "data");//  JSON у XML

            Console.WriteLine(xml.OuterXml);

            
            File.WriteAllText("data.xml", xml.OuterXml);
            Console.WriteLine("Data are in  data.xml");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
