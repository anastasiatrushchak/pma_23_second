import colors.*;
import shapes.*;

public class Main {
    public static void main(String[] args) {
        Color red = new Red("red");
        Color blue = new Blue("blue");
        Color green = new Green("green");
        Shape rect = new Rectangle(red, 15.0, 16.7);
        Shape square = new Square(blue, 15.0);
        Shape tri = new Triangle(green, 5.0, 5.0, 8.0);
        Shape circle = new Circle(red, 17.0);
        System.out.println(rect);
        System.out.println(square);
        System.out.println(tri);
        System.out.println(circle);
    }
}
