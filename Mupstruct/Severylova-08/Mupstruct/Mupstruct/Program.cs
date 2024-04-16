using Mupstruct;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Mapstruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "C:\\Users\\Златомира\\source\\repos\\C#\\Severylova-08\\Mupstruct\\Mupstruct\\file.json";
            string xmlFilePath = "C:\\Users\\Златомира\\source\\repos\\C#\\Severylova-08\\Mupstruct\\Mupstruct\\result.xml";

            string jsonText = File.ReadAllText(jsonFilePath);

            JArray jsonArray = JArray.Parse(jsonText);

            List<JsonData> jsonDataList = new List<JsonData>();

            foreach (JObject jsonObject in jsonArray.Children<JObject>())
            {
                JsonData jsonData = new JsonData
                {
                    IdentificatorId = (string)jsonObject["identificatorId"],
                    Item = new Item
                    {
                        ObjectId = (string)jsonObject["dataItem"]["objectId"],
                        EffectimeFrom = (string)jsonObject["dataItem"]["effectimeFrom"],
                        EffectiveTo = (string)jsonObject["dataItem"]["effectiveTo"],
                        SomeUselessStuff = new string[] { (string)jsonObject["dataItem"]["some_useless_stuff1"] ?? (string)jsonObject["dataItem"]["some_useless_stuff2"] }
                    },
                    Info = new List<Info>()
                };

                if (jsonObject["info"].Type == JTokenType.Object)
                {
                    Info infoItem = new Info
                    {
                        TwoUselessFields = new string[] { (string)jsonObject["info"]["Two_useless_fields"] },
                        CurrentAt = (string)jsonObject["info"]["currentAt"],
                        CurrentFrom = (string)jsonObject["info"]["CurrentFrom"],
                        Type = (string)jsonObject["info"]["type"],
                        ThreeMoreUselessFields = new string[] { (string)jsonObject["info"]["more_useless_field"] }
                    };
                    jsonData.Info.Add(infoItem);
                }
                else if (jsonObject["info"].Type == JTokenType.Array)
                {
                    foreach (JObject infoObject in jsonObject["info"].Children<JObject>())
                    {
                        Info infoItem = new Info
                        {
                            TwoUselessFields = new string[] { (string)infoObject["Two_useless_fields"] },
                            CurrentAt = (string)infoObject["currentAt"],
                            CurrentFrom = (string)infoObject["CurrentFrom"],
                            Type = (string)infoObject["type"],
                            ThreeMoreUselessFields = new string[] { (string)infoObject["more_useless_field"] }
                        };
                        jsonData.Info.Add(infoItem);
                    }
                }

                jsonDataList.Add(jsonData);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<JsonData>));

            using (StreamWriter writer = new StreamWriter(xmlFilePath))
            {
                serializer.Serialize(writer, jsonDataList);
            }
        }
    }
}
