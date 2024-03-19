using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Color
{
    public class Blue : Color
    {
        public override void applyColor()
        {
            Console.WriteLine("Applying blue color");
        }
    }
}
