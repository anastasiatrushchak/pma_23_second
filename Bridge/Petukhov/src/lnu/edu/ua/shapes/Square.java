package lnu.edu.ua.shapes;

import lnu.edu.ua.colors.Color;

public class Square extends Rectangle {
    public Square(Color color, double side) {
        super(color, side, side);
    }



    public String toString() {
        StringBuilder str = new StringBuilder("Square:\n");
        str.append("side: ").append(this.firstSide).append("\n");
        str.append("perimeter: ").append(getPerimeter()).append("\n");
        str.append("area: ").append(getArea()).append("\n");
        str.append("color: ").append(this.color.getColor()).append("\n");
        return str.toString();
    }
}
