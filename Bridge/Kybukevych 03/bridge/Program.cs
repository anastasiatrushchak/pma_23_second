using System;

namespace Bridge
{
    internal class Program
    {
        public abstract class Shape
        {
            protected IColor color;

            public Shape(IColor color)
            {
                this.color = color;
            }

            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();

            // Public property to access the color field
            public IColor Color => color;
        }

        public class Square : Shape
        {
            private double side;

            public Square(double side, IColor color) : base(color)
            {
                this.side = side;
            }

            public override double CalculateArea()
            {
                return side * side;
            }

            public override double CalculatePerimeter()
            {
                return 4 * side;
            }
        }

        public class Rectangle : Shape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height, IColor color) : base(color)
            {
                this.width = width;
                this.height = height;
            }

            public override double CalculateArea()
            {
                return width * height;
            }

            public override double CalculatePerimeter()
            {
                return 2 * (width + height);
            }
        }

        public class Triangle : Shape
        {
            private double side1;
            private double side2;
            private double side3;

            public Triangle(double side1, double side2, double side3, IColor color) : base(color)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            public override double CalculateArea()
            {
                // Assuming Heron's formula for area calculation
                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }

            public override double CalculatePerimeter()
            {
                return side1 + side2 + side3;
            }
        }

        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius, IColor color) : base(color)
            {
                this.radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * radius * radius;
            }

            public override double CalculatePerimeter()
            {
                return 2 * Math.PI * radius;
            }
        }

        public interface IColor
        {
            string Fill();
        }

        public class RedColor : IColor
        {
            public string Fill()
            {
                return "Red";
            }
        }

        public class BlueColor : IColor
        {
            public string Fill()
            {
                return "Blue";
            }
        }

        static void Main(string[] args)
        {
            var red = new RedColor();
            var blue = new BlueColor();

            var square = new Square(4, red);
            var rectangle = new Rectangle(3, 5, blue);
            var triangle = new Triangle(3, 4, 5, red);
            var circle = new Circle(2, blue);

            Console.WriteLine($"Square area: {square.CalculateArea()}, perimeter: {square.CalculatePerimeter()}, color: {square.Color.Fill()}");
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}, perimeter: {rectangle.CalculatePerimeter()}, color: {rectangle.Color.Fill()}");
            Console.WriteLine($"Triangle area: {triangle.CalculateArea()}, perimeter: {triangle.CalculatePerimeter()}, color: {triangle.Color.Fill()}");
            Console.WriteLine($"Circle area: {circle.CalculateArea()}, perimeter: {circle.CalculatePerimeter()}, color: {circle.Color.Fill()}");

            Console.ReadLine();
        }
    }
}
