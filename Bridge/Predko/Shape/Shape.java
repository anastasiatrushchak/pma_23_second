package org.example.Predko.Shape;

import org.example.Predko.Color.Color;

public abstract class Shape {
    public Color color;

    public Shape(Color color) {
        this.color = color;
    }

    public abstract double calculateArea();
    public abstract double calculatePerimeter();
}












