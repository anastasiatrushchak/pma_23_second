using pattern;
using System;

namespace pattern
{
    
    public interface IAbstractFactory
    {
        IHotDrink CreateHotDrink();
        IColdDrink CreateColdDrink();
    }
}
