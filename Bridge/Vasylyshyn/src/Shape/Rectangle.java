package Shape;

import Color.Color;

public class Rectangle extends Shape {
    public int SideB;
    public int SideA;
    public Rectangle() {
    }

    public Rectangle(int sideB, int sideA) {
        SideB = sideB;
        SideA = sideA;
    }

    public Rectangle(Color color, int sideB, int sideA) {
        super(color);
        SideB = sideB;
        SideA = sideA;
    }

    @Override
    public String toString() {
        return "Rectangle{" +
                "SideA=" + SideA +
                ", SideB=" + SideB +
                ", color=" + color +
                '}';
    }

    @Override
    public void draw() {
        System.out.print("It is Rectangle. It is already painted ");
        color.Paint();
    }
    @Override
    public double Area(){
        return this.SideA*this.SideB;
    }

    @Override
    public double Perimeter() {
        return (this.SideA+this.SideB)*2;
    }


    public int getSideB() {
        return SideB;
    }

    public Rectangle setSideB(int sideB) {
        SideB = sideB;
        return this;
    }

    public int getSideA() {
        return SideA;
    }

    public Rectangle setSideA(int sideA) {
        SideA = sideA;
        return this;
    }
}
