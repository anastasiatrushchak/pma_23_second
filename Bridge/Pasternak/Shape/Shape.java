package Inheritance.Shape;

import Inheritance.Color.Color;

public abstract class Shape {
    protected Color color;

    public Shape(final Color color) {
        this.color = color;
    }

    public abstract double getPerimeter();

    public abstract double getArea();
}
