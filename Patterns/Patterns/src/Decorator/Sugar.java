package Decorator;

class Sugar extends CoffeeDecorator {
    public Sugar(Coffee coffee) {
        super(coffee);
    }

    public double getCost() {
        return super.getCost() + 1;
    }

    public String getDescription() {
        return super.getDescription() + " + Sugar";
    }
}
