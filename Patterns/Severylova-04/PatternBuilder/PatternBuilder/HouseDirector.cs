using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class HouseDirector
    {
        public House MakeHouse(Builder builder)
        {
            builder.CreateHouse();
            builder.SetColor();
            builder.SetFloor();
            builder.SetRoom();
            builder.SetArea();

            House house = builder.GetHouse();

            if (house == null)
            {
                throw new InvalidOperationException("Builder failed to create a house.");
            }

            return house;

        }
    }
}
