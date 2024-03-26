using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class BigHouse : Builder
    {
        public override void SetColor()
        {
            GetHouse().color = "White";
        }

        public override void SetFloor()
        {
            GetHouse().floor = 3;
        }

        public override void SetRoom()
        {
            GetHouse().room = 15;
        }

        public override void SetArea()
        {
            GetHouse().area = 105;
        }


    }
}
