using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project.Objects;

[Serializable]
public class DataItem
{
    [XmlAttribute]
    public string ObjectId { get; set; }

    [XmlAttribute]
    public string EffectiveFrom { get; set; }

    [XmlAttribute]
    public string EffectiveTo { get; set; }

    public string Serialize()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(DataItem));
        using (System.IO.StringWriter writer = new System.IO.StringWriter())
        {
            serializer.Serialize(writer, this);
            return writer.ToString();
        }
    }

    public static DataItem DeserializeJson(string jsonData)
    {
        return JsonSerializer.Deserialize<DataItem>(jsonData);
    }
}
