using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project.Objects;

[Serializable]
public class Info
{
    [XmlAttribute]
    public string CurrentAt { get; set; }

    [XmlAttribute]
    public string CurrentFrom { get; set; }

    [XmlAttribute]
    public string Type { get; set; }

    public string Serialize()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Info));
        using (System.IO.StringWriter writer = new System.IO.StringWriter())
        {
            serializer.Serialize(writer, this);
            return writer.ToString();
        }
    }

    public static Info DeserializeJson(string jsonData)
    {
        return JsonSerializer.Deserialize<Info>(jsonData);
    }
}
