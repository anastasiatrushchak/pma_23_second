using System.Xml.Serialization;
using MapJson;
using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static void Main(string[] args)
    {
       // string jsonFilePath = "File.json";
        string xmlFilePath = "output.xml";
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase database = client.GetDatabase("MapJson");
        var collection = database.GetCollection<BsonDocument>("MapJson");
        List<BsonDocument> bsonDocList =  collection.Find(new BsonDocument()).ToList();
        //var jsonArray = bsonDocList.ConvertAll(BsonTypeMapper.MapToDotNetValue);
        // string jsonText = File.ReadAllText(jsonFilePath);
        //
        // JArray jsonArray = JArray.Parse(jsonText);

        List<SomeClass> SomeClasss = new List<SomeClass>();

        foreach (var bson in bsonDocList)
        {
            SomeClass SomeClass = new SomeClass
            {
                identificatorId = (string)bson["identificatorId"].AsString,// знач пол, зада власт
                dataItem = new DataItem
                {
                    objectId = (string)bson["dataItem"]["objectId"],
                    effectimeFrom = (string)bson["dataItem"]["effectimeFrom"],
                    effectiveTo = (string)bson["dataItem"]["effectiveTo"],
                    some_useless_stuff  = (string)bson["dataItem"]["some useless stuff"]
                },
                info = new List<InfoItem>()
            };

            if (bson["info"] is not BsonArray)
            {
                List<string> stringList = new List<string>();

                foreach (BsonValue value in bson["info"]["3 more useless fields"].AsBsonArray)
                {
                    if (!value.IsBsonNull && value.IsString)
                    {
                        stringList.Add(value.AsString);
                    }
                }
                InfoItem infoItem = new InfoItem
                {
                    Two_useless_fielsd = (string)bson["info"]["Two useless fielsd"],
                    currentAt = (string)bson["info"]["currentAt"],
                    CurrentFrom = (string)bson["info"]["CurrentFrom"],
                    type = (string)bson["info"]["type"],
                    three_more_useless_fields = stringList
                };
                SomeClass.info.Add(infoItem);
            }
            else 
            {
                foreach (var infoObject in bson["info"].AsBsonArray)
                {
                    List<string> stringList = new List<string>();

                    foreach (BsonValue value in infoObject["3 more useless fields"].AsBsonArray)
                    {
                        if (!value.IsBsonNull && value.IsString)
                        {
                            stringList.Add(value.AsString);
                        }
                    }
                    InfoItem infoItem = new InfoItem
                    {
                        Two_useless_fielsd = (string)infoObject["Two useless fielsd"],
                        currentAt = (string)infoObject["currentAt"],
                        CurrentFrom = (string)infoObject["CurrentFrom"],
                        type = (string)infoObject["type"],
                        three_more_useless_fields = stringList
                    };
                    SomeClass.info.Add(infoItem);
                }
            }

            SomeClasss.Add(SomeClass);
        }
        XmlSerializer serializer = new XmlSerializer(typeof(List<SomeClass>));

        using (StreamWriter writer = new StreamWriter(xmlFilePath))
        {
            serializer.Serialize(writer, SomeClasss);
        }
       
       // Console.WriteLine(xml);
        //Console.WriteLine(xmlDocument);
        //xmlDocument.Save(xmlFilePath);

        Console.WriteLine("JSON file converted to XML successfully.");
    }
}