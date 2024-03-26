using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IDatabase
    {
        void UpdateData(object newData);
    }
}
