using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using MongoDB.Bson;
using MongoDB.Driver;

public static class Program
{
    public static void Main()
    {
        string connectionString = "mongodb://localhost:27017";
        string databaseName = "SomeData";
        string collectionName = "CollectionForLab";

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        var collection = database.GetCollection<BsonDocument>(collectionName);

        var filter = Builders<BsonDocument>.Filter.Empty;
        var mongoDocuments = collection.Find(filter).ToList();

        var mappedData = new List<MongoData>();
        foreach (var document in mongoDocuments)
        {
            var mongoData = new MongoData
            {
                IdentificatorId = document["identificatorId"].AsString,
                DataItem = new DataItem
                {
                    ObjectId = document["dataItem"]["objectId"].AsString,
                    EffectiveFrom = document["dataItem"]["effectimeFrom"].AsString,
                    EffectiveTo = document["dataItem"]["effectiveTo"].AsString
                },
                Info = new Info
                {
                    CurrentAt = document["info"]["currentAt"].AsString,
                    CurrentFrom = document["info"]["CurrentFrom"].AsString,
                    Type = document["info"]["type"].AsString
                }
            };
            mappedData.Add(mongoData);
        }

        string xmlData = ConvertToXml(mappedData);

        Console.WriteLine(xmlData);
    }

    static string ConvertToXml(Data[] dataArray)
    {
        using (var stringWriter = new StringWriter())
        {
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("DataList");

                foreach (var data in dataArray)
                {
                    xmlWriter.WriteStartElement("Data");

                    xmlWriter.WriteElementString("IdentificatorId", data.IdentificatorId);

                    xmlWriter.WriteStartElement("DataItem");
                    xmlWriter.WriteElementString("ObjectId", data.DataItem.ObjectId);
                    xmlWriter.WriteElementString("EffectiveFrom", data.DataItem.EffectiveFrom);
                    xmlWriter.WriteElementString("EffectiveTo", data.DataItem.EffectiveTo);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Info");
                    xmlWriter.WriteElementString("CurrentAt", data.Info.CurrentAt);
                    xmlWriter.WriteElementString("CurrentFrom", data.Info.CurrentFrom);
                    xmlWriter.WriteElementString("Type", data.Info.Type);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }

            return stringWriter.ToString();
        }
    }
}