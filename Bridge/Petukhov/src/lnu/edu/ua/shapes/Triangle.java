package lnu.edu.ua.shapes;

import lnu.edu.ua.colors.Color;

public class Triangle extends Shape {
    private final double firstSide;
    private final double secondSide;
    private final double thirdSide;

    public Triangle(Color color, double firstSide, double secondSide, double thirdSide) {
        super(color);
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public Double getPerimeter() {
        return this.firstSide + this.secondSide + this.thirdSide;
    }

    public Double getArea() {
        double p = this.firstSide + this.secondSide + this.thirdSide;
        return Math.sqrt(p / 2.0 * (p / 2.0 - this.firstSide) * (p / 2.0 - this.secondSide) * (p / 2.0 - this.thirdSide));
    }

    public String toString() {
        StringBuilder str = new StringBuilder("Triangle:\n");
        str.append("firstSide: ").append(this.firstSide).append("\n");
        str.append("secondSide: ").append(this.secondSide).append("\n");
        str.append("thirdSide: ").append(this.thirdSide).append("\n");
        str.append("perimeter: ").append(getPerimeter()).append("\n");
        str.append("area: ").append(getArea()).append("\n");
        str.append("color: ").append(this.color.getColor()).append("\n");
        return str.toString();
    }
}
