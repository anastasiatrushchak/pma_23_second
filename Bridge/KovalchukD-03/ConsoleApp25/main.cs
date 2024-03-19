using System;


namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape square = new Square(4, BlueColor.Color);
                Shape circle = new Circle(3, RedColor.Color);
                Shape triangle = new Triangle(3, 6, 8, BlueColor.Color);
                Shape rectangle = new Rectangle(5, 6, RedColor.Color);

                square.Draw();
                circle.Draw();
                triangle.Draw();
                rectangle.Draw();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadLine(); 
        }
    }
}
