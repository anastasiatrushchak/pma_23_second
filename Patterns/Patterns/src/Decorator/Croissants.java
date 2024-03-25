package Decorator;

public class Croissants extends CoffeeDecorator{
    public Croissants(Coffee coffee) {
        super(coffee);
    }

    @Override
    public double getCost() {
        return super.getCost()+40;
    }

    @Override
    public String getDescription() {
        return super.getDescription()+" + croissants";
    }
}
