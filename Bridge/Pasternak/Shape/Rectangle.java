package Inheritance.Shape;


import Inheritance.Color.Color;

public class Rectangle extends Shape {
    protected double firstSide;
    protected double secondSide;

    public Rectangle(Color color, double firstSide, double secondSide) {
        super(color);
        this.firstSide = firstSide;
        this.secondSide = secondSide;
    }

    public double getPerimeter() {
        return firstSide*2 + secondSide*2;
    }

    public double getArea() {
        return firstSide * secondSide;
    }
    public String toString() {
        return "Rectangle{FirstSide=" + firstSide + ", SecondSide=" + secondSide + ", color=" + this.color + ", perimeter=" + this.getPerimeter() + ", area=" + this.getArea() + "}";
    }

}