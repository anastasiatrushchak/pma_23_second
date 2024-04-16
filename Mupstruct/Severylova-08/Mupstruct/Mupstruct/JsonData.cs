using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mupstruct
{
    public class JsonData
    {
        public string IdentificatorId { get; set; }
        public Item Item { get; set; }
        public List<Info> Info { get; set; }
    }
}
