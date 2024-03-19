package shapes;

import colors.Color;

public class Circle extends Shape {
    private final double PI = 3.14;
    private double r;

    public Circle(Color color, double r) {
        super(color);
        this.r = r;

    }

    @Override
    protected double countArea() {
        return Math.pow(r, 2) * PI;
    }

    @Override
    protected double countPerimeter() {
        return 2 * PI * r;
    }
}
