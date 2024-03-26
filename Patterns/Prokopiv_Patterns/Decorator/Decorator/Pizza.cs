public class Pizza : Dish
{
    public override string GetDescription()
    {
        return "Pizza";
    }

    public override double GetCost()
    {
        return 10.99;
    }
}