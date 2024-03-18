package Inheritance;


import Inheritance.Color.Color;
import Inheritance.Color.Red;
import Inheritance.Color.White;
import Inheritance.Shape.Circle;
import Inheritance.Shape.Rectangle;
import Inheritance.Shape.Square;
import Inheritance.Shape.Triangle;

public class Main {
    public Main() {
    }

    public static void main(String[] args) {
        Square square = new Square(12.0, new White());
        System.out.println(square);
        Rectangle rectangle = new Rectangle( new White(), 2.0, 23);
        System.out.println(rectangle);
        Triangle triangle = new Triangle(12.0, 6.0, 8.0, new Red());
        System.out.println(triangle);
        Circle circle = new Circle(12.0, new Red());
        System.out.println(circle);
    }
}
