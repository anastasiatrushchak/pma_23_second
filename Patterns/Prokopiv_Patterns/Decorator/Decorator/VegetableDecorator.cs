public class VegetableDecorator : IngredientDecorator
{
    public VegetableDecorator(Dish dish) : base(dish)
    {
    }

    public override string GetDescription()
    {
        return _dish.GetDescription() + ", with Vegetables";
    }

    public override double GetCost()
    {
        return _dish.GetCost() + 1.00; // Вартість овочів
    }
}