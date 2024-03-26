public abstract class IngredientDecorator : Dish
{
    protected Dish _dish;

    public IngredientDecorator(Dish dish)
    {
        _dish = dish;
    }

    public override string GetDescription()
    {
        return _dish.GetDescription();
    }

    public override double GetCost()
    {
        return _dish.GetCost();
    }
}
