package Inheritance.Shape;

import Inheritance.Color.Color;

public class Circle extends Shape {
    double radius;

    public Circle(double radius, Color color) {
        super(color);
        this.radius = radius;
    }

    public double getPerimeter() {
        return 2.0 * this.radius * Math.PI;
    }

    public double getArea() {
        return Math.pow(this.radius, 2.0) * Math.PI;
    }
    @Override
    public String toString() {
        return "Сircle{radius=" + radius + ", perimeter=" + getPerimeter() + ", area=" + getArea() + ", color=" + this.color + "}";
    }
}
