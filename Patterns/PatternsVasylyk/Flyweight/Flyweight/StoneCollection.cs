namespace Flyweight;

class StoneCollection
{
    private List<Stone> stones = new List<Stone>();

    public void AddStone(int weight, string name, string color, string origin)
    {
        var type = StoneFactory.GetTreeType(name, color, origin);
        var tree = new Stone(weight, type);
        stones.Add(tree);
    }

    public void Draw()
    {
        foreach (var stone in stones)
        {
            stone.Draw();
        }
    }
}