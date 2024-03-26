package org.example.Predko_04.Flyweight;

public class Main {
    public static void main(String[] args) {
        FlyweightFactory factory = new FlyweightFactory();

        Flyweight flyweight1 = factory.getFlyweight("apple");
        Flyweight flyweight2 = factory.getFlyweight("coconut");

        flyweight1.operation();
        flyweight2.operation();
    }
}


