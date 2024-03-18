package shapes;

import colors.Color;

public abstract class Shape {
    protected Color color;

    public Shape(Color color) {
        this.color = color;
    }

    protected abstract double countArea();

    protected abstract double countPerimeter();

    @Override
    public String toString() {
        return this.getClass().getSimpleName() +
                " color = " + color +
                " area = " + this.countArea() +
                " perimeter = " + this.countPerimeter();
    }
}
