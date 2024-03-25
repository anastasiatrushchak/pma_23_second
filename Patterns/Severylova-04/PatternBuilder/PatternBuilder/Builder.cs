using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public abstract class Builder
    {
        protected House house;
        public abstract void SetColor();
        public abstract void SetFloor();
        public abstract void SetRoom();
        public abstract void SetArea();

        public void CreateHouse()
        {
            house = new House();
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
