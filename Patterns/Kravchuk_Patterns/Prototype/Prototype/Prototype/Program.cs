using System;

public class Point : ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

//клонуємо
    public object Clone()
    {
        return new Point(X, Y, Z);
    }

    public void PrintCoordinates()
    {
        Console.WriteLine($"({X}, {Y}, {Z})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point originalPoint = new Point(10, 9, 8);

        Point clonedPoint = (Point)originalPoint.Clone();

        clonedPoint.X = 4;
        clonedPoint.Y = 5;
        clonedPoint.Z = 6;

        Console.WriteLine("Original Point:");
        originalPoint.PrintCoordinates();
        Console.WriteLine("Cloned Point:");
        clonedPoint.PrintCoordinates();

        Console.ReadLine();
    }
}
