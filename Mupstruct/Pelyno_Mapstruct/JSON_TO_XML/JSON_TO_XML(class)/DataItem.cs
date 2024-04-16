using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_XML
{
    public class DataItem
    {
        public string objectId { get; set; }
        public string effectimeFrom { get; set; }
        public string effectiveTo { get; set; }
        public string destination { get; set; }
        public string accommodationType { get; set; }
        public string[] activities { get; set; }
    }

}
