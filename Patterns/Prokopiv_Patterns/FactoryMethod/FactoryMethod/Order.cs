class Order
{
    private List<Furniture> _furnitureList = new List<Furniture>();

    public void AddFurniture(Furniture furniture)
    {
        _furnitureList.Add(furniture);
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Order:");
        foreach (var furniture in _furnitureList)
        {
            Console.WriteLine(furniture.GetName());
        }

        if (HasDifferentStyles())
        {
            Console.WriteLine("The furniture in this order has different styles.");
        }
    }

    private bool HasDifferentStyles()
    {
        var styles = new HashSet<string>();
        foreach (var furniture in _furnitureList)
        {
            styles.Add(furniture._style);
        }
        return styles.Count > 1;
    }
}