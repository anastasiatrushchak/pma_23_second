package lnu.edu.ua;

import lnu.edu.ua.colors.Blue;
import lnu.edu.ua.colors.Color;
import lnu.edu.ua.colors.Red;
import lnu.edu.ua.shapes.*;

public class Main {
    public static void main(String[] args) {
        // Colors:
        Color red = new Red();
        Color blue = new Blue();
        Color yellow = new Color("Yellow");

//        Shape square = new Square(red, 10);
//        System.out.println(square);
//        Rectangle rectangle = new Rectangle(blue, 10, 20);
//        System.out.println(rectangle);
//        Triangle triangle = new Triangle(yellow,10, 20, 30);
//        System.out.println(triangle);
//        Circle circle = new Circle(blue, 10);
//        System.out.println(circle);

        Triangle triangle1 = new Triangle(yellow, 5, 5, 8);
        System.out.println(triangle1);
    }
}