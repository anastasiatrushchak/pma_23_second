using System;

class Circle : Shape
{
    private double radius; // Радіус кола

    public Circle(double radius, IColor color) : base(color)
    {
        this.radius = radius;
    }

    public override string Draw()              // Метод кола та кольору
    {
        return $"Коло. {color.Fill()}";
    }

    public override double GetArea()              // Площа кола
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()           // Периметр кола
    {
        return 2 * Math.PI * radius;
    }
}

class Square : Rectangle
{
    private double side;                         // Довжина сторони квадрата

    public Square(double side, IColor color) : base(side, side, color)
    {
        this.side = side;
    }

    public override string Draw()
    {
        return $"Квадрат. {color.Fill()}";
    }

    public override double GetArea()                     // Площа квадрата
    {
        return side * side;
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }
}

class Rectangle : Shape
{
    private double length; 
    private double width; 

    public Rectangle(double length, double width, IColor color) : base(color)
    {
        this.length = length;
        this.width = width;
    }

    public override string Draw()
    {
        return $"Прямокутник. {color.Fill()}";
    }

    public override double GetArea()
    {
        return length * width;
    }

    public override double GetPerimeter()
    {
        return 2 * (length + width);
    }
}

class Triangle : Shape
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

    public override string Draw()
    {
        return $"Трикутник. {color.Fill()}";
    }

    public override double GetArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double GetPerimeter()
    {
        return side1 + side2 + side3;
    }
}
