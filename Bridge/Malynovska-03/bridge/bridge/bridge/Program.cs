using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Color[] colors = { new Red(), new Pink(), new Blue() };
            List<Shape> shapes = new List<Shape>();
            try
            { 
                shapes.Add(new Rectangle(4, 5, colors[0]));
                shapes.Add(new Circle(5, colors[2]));
                shapes.Add(new Square(6, colors[1]));
                shapes.Add(new Triangle(13, 8, 10, colors[2]));
             }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (Shape shape in shapes)
            {
                shape.Info();
            }
           
            

        }
    }
}
