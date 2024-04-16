using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project.Objects;

[Serializable]
public class Data
{
    [XmlAttribute]
    public string IdentificatorId { get; set; }
    
    [XmlAttribute]
    public DataItem DataItem { get; set; }

    [XmlAttribute]
    public Info Info { get; set; }

    public string Serialize()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Data));
        using (System.IO.StringWriter writer = new System.IO.StringWriter())
        {
            serializer.Serialize(writer, this);
            return writer.ToString();
        }
    }

    public static Data DeserializeJson(string jsonData)
    {
        return JsonSerializer.Deserialize<Data>(jsonData);
    }

}
