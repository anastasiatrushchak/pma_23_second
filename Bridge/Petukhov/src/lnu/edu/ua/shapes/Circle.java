package lnu.edu.ua.shapes;

import lnu.edu.ua.colors.Color;

public class Circle extends Shape {
    private double radius;

    public Circle(Color color, double radius) {
        super(color);
        this.radius = radius;
    }

    public Double getPerimeter() {
        return 2.0 * this.radius * Math.PI;
    }

    public Double getArea() {
        return Math.pow(this.radius, 2.0) * Math.PI;
    }

    @Override
    public String toString() {
        StringBuilder str = new StringBuilder("Circle:\n");
        str.append("radius: ").append(this.radius).append("\n");
        str.append("perimeter: ").append(getPerimeter()).append("\n");
        str.append("area: ").append(getArea()).append("\n");
        str.append("color: ").append(this.color.getColor()).append("\n");
        return str.toString();
    }
}