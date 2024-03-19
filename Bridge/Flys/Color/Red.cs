using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Color
{
    public class Red : Color

    {
        public override void applyColor()
        {
            Console.WriteLine("Applying red color");
        }
    }
}
