using System;
using System.Collections.Generic;
using Bridge.Color;
using Bridge.Shape;

namespace Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Bridge.Shape.Shape> shapes = new List<Bridge.Shape.Shape>
            {
                new Rectangle(5, 10, new Green()),
                new Circle(5, new Green()),
                new Square(5, new Blue()),
                new Circle(5, new Red()),
                new Triangle(5, 5, 8, new Red())
            };

            foreach (var shape in shapes)
            {
                shape.draw();
                Console.WriteLine("Perimeter of " + shape.GetType().Name + ": " + shape.getPerimeter());
                Console.WriteLine("Area of " + shape.GetType().Name + ": " + shape.getArea());
                Console.WriteLine();
            }
        }
    }
}