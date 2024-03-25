package Decorator;

class Milk extends CoffeeDecorator {
    public Milk(Coffee coffee) {
        super(coffee);
    }

    public double getCost() {
        return super.getCost() + 2;
    }

    public String getDescription() {
        return super.getDescription() + " + Milk";
    }
}
