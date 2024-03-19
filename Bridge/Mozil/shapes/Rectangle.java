package shapes;

import colors.Color;

public class Rectangle extends Shape {
    protected double width;
    private double height;

    public Rectangle(Color color, double width, double height) {
        super(color);
        this.width = width;
        this.height = height;
    }

    @Override
    protected double countArea() {
        return width * height;
    }

    @Override
    protected double countPerimeter() {
        return 2 * width + 2 * height;
    }
}
