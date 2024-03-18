package org.example.Predko;

import org.example.Predko.Color.Blue;
import org.example.Predko.Color.Color;
import org.example.Predko.Color.Green;
import org.example.Predko.Color.Red;
import org.example.Predko.Shape.*;

public class Main {
    public static void main(String[] args) {
        Color red = new Red();
        Color green = new Green();
        Color blue = new Blue();

        Shape square = new Square(4, red);
        Shape rectangle = new Rectangle(4, 6, green);
        Shape triangle = new Triangle(5, 5, 8, blue);
        Shape circle = new Circle(5, red);

        System.out.println("Square Area: " + square.calculateArea());
        System.out.println("Square Perimeter: " + square.calculatePerimeter());
        System.out.println("Square Color: " + square.color.fill()+"\n");

        System.out.println("Rectangle Area: " + rectangle.calculateArea());
        System.out.println("Rectangle Perimeter: " + rectangle.calculatePerimeter());
        System.out.println("Rectangle Color: " + rectangle.color.fill()+"\n");

        System.out.println("Triangle Area: " + triangle.calculateArea());
        System.out.println("Triangle Perimeter: " + triangle.calculatePerimeter());
        System.out.println("Triangle Color: " + triangle.color.fill()+"\n");

        System.out.println("Circle Area: " + circle.calculateArea());
        System.out.println("Circle Perimeter: " + circle.calculatePerimeter());
        System.out.println("Circle Color: " + circle.color.fill());
    }
}