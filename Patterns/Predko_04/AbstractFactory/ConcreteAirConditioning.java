package org.example.Predko_04.AbstractFactory;

public class ConcreteAirConditioning implements AbstractCar {
    @Override
    public String doSomething() {
        return "We make air conditioning.";
    }
}