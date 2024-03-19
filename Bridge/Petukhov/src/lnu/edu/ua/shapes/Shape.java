package lnu.edu.ua.shapes;

import lnu.edu.ua.colors.Color;

public abstract class Shape {
    protected Color color;

    public Shape(Color color) {
        this.color = color;
    }

    public abstract Double getPerimeter();

    public abstract Double getArea();

}
