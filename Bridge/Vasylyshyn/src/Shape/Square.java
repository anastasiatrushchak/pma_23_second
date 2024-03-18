package Shape;

import Color.Color;

public class Square extends Rectangle {
    public Square(Color color, int sideB, int sideA) {
        super(color, sideB, sideA);
    }

    public Square() {

    }

    @Override
    public void draw() {
        System.out.print("It is Square. It is already painted ");
        color.Paint();
    }


}
