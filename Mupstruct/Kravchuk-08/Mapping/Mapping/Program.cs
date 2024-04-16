using System;
using System.IO;
using System.Text.Json;
using System.Xml;

class Program
{
    static void Main()
    {
        string json = @"{
          ""items"": [
            {
              ""identificatorId"": ""some_identificator_8_number"",
              ""dataItem"": {
                ""objectId"": ""some_10_number_id"",
                ""effectimeFrom"": ""some_date_in_string"",
                ""effectiveTo"": ""some_date_in_string"",
                ""some useless stuff"": ""add 3 string fields""
              },
              ""info"": {
                ""Two useless fielsd"": ""some Strings"",
                ""currentAt"": ""some_date_in_string"",
                ""CurrentFrom"": ""some_date_in_string"",
                ""type"": ""some_ string"",
                ""3 more useless fields"": """"
              }
            },
            {
              ""identificatorId"": ""some_identificator_8_number"",
              ""dataItem"": {
                ""objectId"": ""some_10_number_id"",
                ""effectimeFrom"": ""some_date_in_string"",
                ""effectiveTo"": ""some_date_in_string"",
                ""some useless stuff"": ""add 3 string fields""
              },
              ""info"": [
                {
                  ""Two useless fielsd"": ""some Strings"",
                  ""currentAt"": ""some_date_in_string"",
                  ""CurrentFrom"": ""some_date_in_string"",
                  ""type"": ""some_ string"",
                  ""3 more useless fields"": """"
                },
                {
                  ""Two useless fielsd"": ""some Strings"",
                  ""currentAt"": ""some_date_in_string"",
                  ""CurrentFrom"": ""some_date_in_string"",
                  ""type"": ""some_ string"",
                  ""3 more useless fields"": """"
                }
              ]
            }
          ]
        }";

        JsonDocument jsonDocument = JsonDocument.Parse(json);

        XmlDocument xmlDocument = new XmlDocument();
        XmlElement rootElement = xmlDocument.CreateElement("root");
        xmlDocument.AppendChild(rootElement);

        foreach (JsonProperty property in jsonDocument.RootElement.EnumerateObject())
        {
            XmlElement element = xmlDocument.CreateElement(property.Name);
            element.InnerText = property.Value.ToString();
            rootElement.AppendChild(element);
        }

        xmlDocument.Save("result.xml");

        Console.WriteLine("XML saved.");
    }
}
