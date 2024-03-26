namespace Flyweight;

class Stone
{
    private int weight;
    private StoneType type;

    public Stone(int weight, StoneType type)
    {
        this.weight = weight;
        this.type = type;
    }

    public void Draw()
    {
        type.Draw(weight);
    }
}