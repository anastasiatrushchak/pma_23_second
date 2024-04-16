using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MapStruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "file.json";
            string xmlFilePath = "output.xml";

            string jsonText = File.ReadAllText(jsonFilePath);

            JArray jsonArray = JArray.Parse(jsonText);

            List<General> Generals = new List<General>();

            foreach (JObject jsonObject in jsonArray.Children<JObject>())
            {
                General General = new General
                {
                    Id = (string)jsonObject["identificatorId"],
                    Item = new Item
                    {
                        Id = (string)jsonObject["dataItem"]["objectId"],
                        EffectTimeFrom = (string)jsonObject["dataItem"]["effectimeFrom"],
                        EffectTimeTo = (string)jsonObject["dataItem"]["effectiveTo"],
                        Stuff = (string)jsonObject["dataItem"]["some useless stuff"]
                    },
                    Info = new List<Info>()
                };

                if (jsonObject["info"].Type == JTokenType.Object)
                {
                    Info infoItem = new Info
                    {
                        Field = (string)jsonObject["info"]["Two useless fielsd"],
                        CurrentAt = (string)jsonObject["info"]["currentAt"],
                        CurrentFrom = (string)jsonObject["info"]["CurrentFrom"],
                        Type = (string)jsonObject["info"]["type"],
                        Fields = ((JArray)jsonObject["info"]["3 more useless fields"]).ToObject<List<string>>()
                    };
                    General.Info.Add(infoItem);
                }
                else if (jsonObject["info"].Type == JTokenType.Array)
                {
                    foreach (JObject infoObject in jsonObject["info"].Children<JObject>())
                    {
                        Info infoItem = new Info
                        {
                            Field = (string)infoObject["Two useless fielsd"],
                            CurrentAt = (string)infoObject["currentAt"],
                            CurrentFrom = (string)infoObject["CurrentFrom"],
                            Type = (string)infoObject["type"],
                            Fields = ((JArray)infoObject["3 more useless fields"]).ToObject<List<string>>()
                        };
                        General.Info.Add(infoItem);
                    }
                }

                Generals.Add(General);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<General>));

            using (StreamWriter writer = new StreamWriter(xmlFilePath))
            {
                serializer.Serialize(writer, Generals);
            }
        }
    }
}
