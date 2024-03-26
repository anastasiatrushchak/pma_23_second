namespace Flyweight;

class StoneFactory
{
    private static Dictionary<Tuple<string, string, string>, StoneType> stoneTypes = new Dictionary<Tuple<string, string, string>, StoneType>();

    public static StoneType GetTreeType(string name, string color, string origin)
    {
        var key = Tuple.Create(name, color, origin);
        if (!stoneTypes.ContainsKey(key))
        {
            stoneTypes[key] = new StoneType(name, color, origin);
        }
        return stoneTypes[key];
    }
}
