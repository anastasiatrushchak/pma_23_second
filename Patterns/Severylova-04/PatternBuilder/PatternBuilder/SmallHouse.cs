using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class SmallHouse : Builder
    {
        public override void SetColor()
        {
            GetHouse().color = "Red";
        }

        public override void SetFloor()
        {
            GetHouse().floor = 1;
        }

        public override void SetRoom()
        {
            GetHouse().room = 4;
        }

        public override void SetArea()
        {
            GetHouse().area = 36;
        }
    }
}
