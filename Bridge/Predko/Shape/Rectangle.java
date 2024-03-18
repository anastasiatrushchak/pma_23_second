package org.example.Predko.Shape;

import org.example.Predko.Color.Color;

public class Rectangle extends Shape {
    protected double length;
    private double width;

    public Rectangle(double length, double width, Color color) {
        super(color);
        this.length = length;
        this.width = width;
    }

    public double calculateArea() {
        return length * width;
    }

    public double calculatePerimeter() {
        return 2 * (length + width);
    }
}