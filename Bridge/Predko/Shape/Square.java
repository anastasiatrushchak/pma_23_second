package org.example.Predko.Shape;

import org.example.Predko.Color.Color;

public class Square extends Rectangle {

    public Square(double side, Color color) {
        super(side,side,color);
        this.length = side;
    }
}