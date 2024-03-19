package lnu.edu.ua.shapes;

import lnu.edu.ua.colors.Color;

public class Rectangle extends Shape {
    protected double firstSide;
    protected double secondSide;

    public Rectangle(Color color, double firstSide, double secondSide) {
        super(color);
        this.firstSide = firstSide;
        this.secondSide = secondSide;
    }

    public Double getPerimeter() {
        return firstSide*2 + secondSide*2;
    }

    public Double getArea() {
        return firstSide * secondSide;
    }
    public String toString() {
        StringBuilder str = new StringBuilder("Rectangle:\n");
        str.append("firstSide: ").append(this.firstSide).append("\n");
        str.append("secondSide: ").append(this.secondSide).append("\n");
        str.append("perimeter: ").append(getPerimeter()).append("\n");
        str.append("area: ").append(getArea()).append("\n");
        str.append("color: ").append(this.color.getColor()).append("\n");
        return str.toString();
    }
}
