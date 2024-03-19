package Shape;

import Color.Color;

public class Circle extends Shape {
    public int r;

    public Circle(Color color, int r) {
        super( color);
        this.r=r;
    }

    public Circle() {
    }

    @Override
    public String toString() {
        return "Circle{" +
                "r=" + r +
                ", color=" + color +
                '}';
    }

    @Override
    public double Area() {
        return this.r*Math.PI*Math.PI;
    }

    @Override
    public double Perimeter() {
        return 2*Math.PI*this.r;
    }

    @Override
    public void draw() {
        System.out.println("It is Circle. It is already painted");
        color.Paint();

    }
}
