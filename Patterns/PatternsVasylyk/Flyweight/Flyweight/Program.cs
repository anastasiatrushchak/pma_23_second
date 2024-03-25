namespace Flyweight;
class Program
{
    static void Main(string[] args)
    {
        var collection = new StoneCollection();
        collection.AddStone(4, "Diamond", "White", "India");
        collection.AddStone(7, "Sapphire", "Blue", "Australia");
        collection.AddStone(5, "Ruby", "Red", "Kenya");

        collection.Draw();
    }
}
