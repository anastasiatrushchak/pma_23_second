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
            Console.WriteLine("Введіть parkingId: ");
            int id= Convert.ToInt32(Console.ReadLine());
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Mupstruct");
            var collection = database.GetCollection<BsonDocument>("Mupstruct");


            var filter = Builders<BsonDocument>.Filter.Eq("parkingId", id);
            var document = collection.Find(filter).FirstOrDefault();


            if (document != null)
            {
                document.Remove("_id");

               
                var json = document.ToJson();

               
                var jObject = JObject.Parse(json);

                
                var formattedJson = JToken.FromObject(jObject);

               
                var xml = JsonConvert.DeserializeXmlNode(formattedJson.ToString(), "data");

                
                Console.WriteLine(xml.OuterXml);
                
                File.WriteAllText("data.xml", xml.OuterXml);
                Console.WriteLine("Дані записано у файл data.xml");
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
