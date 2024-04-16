using JSON_XML;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_XML
{
    public class Vacation
    {
        public ObjectId? Id { get; set; }
        public string identificatorId { get; set; }
        public DataItem dataItem { get; set; }
        public Info info { get; set; }
    }
}
