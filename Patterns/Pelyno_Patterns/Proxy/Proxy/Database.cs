using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Database : IDatabase
    {
        public void UpdateData(object newData)
        {
            Console.WriteLine($"Updating data: {newData}");
        }
    }
}
