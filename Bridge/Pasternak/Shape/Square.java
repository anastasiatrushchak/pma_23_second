package Inheritance.Shape;

import Inheritance.Color.Color;

public class Square extends Rectangle {
    public Square(double side, Color color) {
        super(color, side, side);
    }

    public String toString() {
        return "Square{side=" + firstSide + ", color=" + color + ", perimeter=" + getPerimeter() + ", area=" + getArea() + "}";
    }
}