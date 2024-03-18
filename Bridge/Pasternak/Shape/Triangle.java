package Inheritance.Shape;


import Inheritance.Color.Color;

public class Triangle extends Shape {
    private double firstSide;
    private double secondSide;
    private double thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide, Color color) {
        super(color);
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public double getPerimeter() {
        return this.firstSide + this.secondSide + this.thirdSide;
    }

    public double getArea() {
        double p = getPerimeter()/2;
        return Math.sqrt(p  * (p - this.firstSide) * (p - this.secondSide) * (p - this.thirdSide));
    }

    public String toString() {
        return "Triangle{firstSide=" + this.firstSide + ", secondSide=" + this.secondSide + ", thirdSide=" + this.thirdSide + ", perimeter=" + this.getPerimeter() + ", area=" + this.getArea() + ", color=" + this.color + "}";
    }
}
