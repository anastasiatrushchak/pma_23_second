using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    internal class NotEqualSizesException: Exception
    {
        public NotEqualSizesException() : base("Error! Matrix's sizes are not equal!") { }
    }
}
