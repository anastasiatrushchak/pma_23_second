public class CheeseDecorator : IngredientDecorator
{
    public CheeseDecorator(Dish dish) : base(dish)
    {
    }

    public override string GetDescription()
    {
        return _dish.GetDescription() + ", with Cheese";
    }

    public override double GetCost()
    {
        return _dish.GetCost() + 1.50; // Вартість сиру
    }
}