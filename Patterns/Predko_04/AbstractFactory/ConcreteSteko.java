package org.example.Predko_04.AbstractFactory;

public class ConcreteSteko implements AbstractFactory {
    @Override
    public AbstractCar createProductA() {
        return new ConcreteAirConditioning();
    }

    @Override
    public AbstractGlassProducts createProductB() {
        return new ConcreteShowcase();
    }
}
