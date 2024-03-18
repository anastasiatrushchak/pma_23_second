import Color.GreenColor;
import Color.RedColor;
import Shape.Square;
import Shape.Triangle;

public class MainClass{
    public static void main(String[] args) {
        RedColor redColor=new RedColor();
        GreenColor greenColor=new GreenColor();
        Triangle triangle=new Triangle( redColor,5,5,8);
        triangle.draw();
        System.out.println(triangle.Area());
        System.out.println(triangle.Perimeter());
        Square square=new Square();
        square.setColor(greenColor);
        square.setSideA(1);
        square.setSideB(2);
        square.draw();
        System.out.println(square);
        square.setColor(redColor);
        square.draw();
        System.out.println();

    }

}