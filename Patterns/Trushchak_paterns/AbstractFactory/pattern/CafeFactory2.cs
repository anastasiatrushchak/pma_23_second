using pattern;
using System;

namespace pattern
{
    public class CafeFactory2 : IAbstractFactory
    {
        public IHotDrink CreateHotDrink()
        {
            return new Cappuccino();
        }

        public IColdDrink CreateColdDrink()
        {
            return new Lemonade();
        }
    }
}
