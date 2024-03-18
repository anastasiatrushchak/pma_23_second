package Shape;

import Color.Color;

public abstract class Shape {
    protected Color color;
    public abstract double Area();
    public abstract double Perimeter();
    public abstract void draw();

    public Shape() {
    }

    public Shape(Color color) {

        this.color = color;
    }

    public Color getColor() {
        return color;
    }

    public Shape setColor(Color color) {
        this.color = color;
        return this;
    }




    @Override
    public String toString() {
        return "Shape{" +
                ", color=" + color +
                '}';
    }
}
