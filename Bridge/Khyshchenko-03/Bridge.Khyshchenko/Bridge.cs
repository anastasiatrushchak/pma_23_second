// Абстрактний клас для фігур
abstract class Shape
{
    protected IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract string Draw();
    public abstract double GetArea();
    public abstract double GetPerimeter();
}
