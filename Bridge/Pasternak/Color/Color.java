package Inheritance.Color;

public abstract class Color {
    private String color;
    Color(String color){
        this.color =  color;
    }

    @Override
    public String toString() {
        return color;
    }
}
