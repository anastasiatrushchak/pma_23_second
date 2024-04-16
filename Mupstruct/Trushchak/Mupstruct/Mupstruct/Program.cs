using System;
using System.IO;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
          
            Console.WriteLine("Input id:");
            string inputId = Console.ReadLine();

            if (ObjectId.TryParse(inputId, out var objectId))
            {
                
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Baza");
                var collection = database.GetCollection<BsonDocument>("Baza");

               
                var document = collection.Find(new BsonDocument("_id", objectId)).FirstOrDefault();

                if (document != null)
                {
                    document.Remove("_id");

                    
                    var json = document.ToJson();
                    var jObject = JObject.Parse(json);
                    var formattedJson = JToken.FromObject(jObject);
                    var xml = JsonConvert.DeserializeXmlNode(formattedJson.ToString(), "root");

                  
                    File.WriteAllText("result.xml", xml.OuterXml);
                }
                else
                {
                    Console.WriteLine("Not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Id input.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
