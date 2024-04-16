using System;
using System.IO;
using System.Xml;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace JSON_XML
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Travel");
                var collection = database.GetCollection<Vacation>("Vacation");

                
                var vacation = collection.Find(x => x.identificatorId == "24681357").FirstOrDefault();

                if (vacation != null)
                {
                   
                    var json = JsonConvert.SerializeObject(vacation);

             
                    var xml = JsonConvert.DeserializeXmlNode(json, "root");

                   
                    File.WriteAllText("JSON_TO_XML.xml", xml.OuterXml);
                }
                else
                {
                    Console.WriteLine("Document not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}