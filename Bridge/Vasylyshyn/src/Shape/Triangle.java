package Shape;

import Color.Color;

public class Triangle extends Shape {
    int SideC;
    int SideA;
    int SideB;

    public Triangle(Color color, int sideC, int sideA, int sideB) {
        super(color);
        SideC = sideC;
        SideA = sideA;
        SideB = sideB;
    }

    public Triangle(int sideC) {
        SideC = sideC;
    }


    public Triangle() {

    }

    public int getSideC() {
        return SideC;
    }

    public Triangle setSideC(int sideC) {
        SideC = sideC;
        return this;
    }

    @Override
    public String toString() {
        return "Triangle{" +
                "SideC=" + SideC +
                ", SideA=" + SideA +
                ", SideB=" + SideB +
                ", color=" + color +
                '}';
    }

    @Override
    public double Area() {
        return Math.sqrt(Perimeter()/2*((Perimeter()/2-this.SideA)*(Perimeter()/2-this.SideB)*(Perimeter()/2-this.SideC)));
    }

    @Override
    public double Perimeter() {
        return this.SideC+this.SideA+this.SideB;
    }

    @Override
    public void draw() {
        System.out.println("It is Triangle. It is already painted");
        color.Paint();

    }

    public int getSideA() {
        return SideA;
    }

    public Triangle setSideA(int sideA) {
        SideA = sideA;
        return this;
    }

    public int getSideB() {
        return SideB;
    }

    public Triangle setSideB(int sideB) {
        SideB = sideB;
        return this;
    }
}
