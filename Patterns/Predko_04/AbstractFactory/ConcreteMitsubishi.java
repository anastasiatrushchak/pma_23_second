package org.example.Predko_04.AbstractFactory;


public class ConcreteMitsubishi implements AbstractFactory {
    @Override
    public AbstractCar createProductA() {
        return new ConcreteCar();
    }

    @Override
    public AbstractGlassProducts createProductB() {
        return new ConcreteWindows();
    }
}