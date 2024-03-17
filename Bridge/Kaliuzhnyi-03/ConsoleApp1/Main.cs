using Bridge.Colors;
using Bridge.Shapes;

namespace Bridge;

public class Bridge
{
    public static void Main()
    {
        try
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Triangle(5, 2, 2, new Red());
            shapes[1] = new Circle(1, new Green());
            shapes[2] = new Rectangle(10, 5, new Blue());
            shapes[3] = new Square(3, new Orange());
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Area = " + shape.Area().ToString() + "; Perimeter = " + shape.Perimeter().ToString());
                Console.WriteLine(shape.ToString());
                Console.WriteLine("------------------------------------");
            }
            Circle circle = new (1, new Green());
            Console.WriteLine(circle.Perimeter(2).ToString());
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        } 
    }
}