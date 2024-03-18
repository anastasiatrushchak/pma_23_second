package shapes;

import colors.Color;

public class Triangle extends Shape {
    private double a;
    private double b;
    private double c;

    public Triangle(Color color, double a, double b, double c) {
        super(color);
        this.a = a;
        this.b = b;
        this.c = c;
    }

    @Override
    protected double countArea() {
        double p = this.countPerimeter();
        return Math.sqrt(p / 2.0 * (p / 2.0 - this.a) * (p / 2.0 - this.b) * (p / 2.0 - this.c));
    }

    @Override
    protected double countPerimeter() {
        return a + b + c;
    }
}
