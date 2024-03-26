using pattern;
using System;

namespace pattern
{
    
    public class CafeFactory1 : IAbstractFactory
    {
        public IHotDrink CreateHotDrink()
        {
            return new Espresso();
        }

        public IColdDrink CreateColdDrink()
        {
            return new IcedTea();
        }
    }
}
