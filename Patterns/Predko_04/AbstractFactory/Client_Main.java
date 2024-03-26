package org.example.Predko_04.AbstractFactory;


public class Client_Main {
    public static String clientCode(AbstractFactory factory) {
        AbstractCar productA = factory.createProductA();
        AbstractGlassProducts productB = factory.createProductB();

        String resultA = productA.doSomething();
        String resultB = productB.doAnotherThing();

        return resultA + "\n" + resultB;
    }

    public static void main(String[] args) {
        AbstractFactory factory1 = new ConcreteMitsubishi();
        System.out.println("Client: Using Mitsubishi");
        System.out.println(clientCode(factory1));

        AbstractFactory factory2 = new ConcreteSteko();
        System.out.println("Client: Using Steko");
        System.out.println(clientCode(factory2));
    }
}
