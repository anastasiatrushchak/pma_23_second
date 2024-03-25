package Decorator;

public class MoreWater extends CoffeeDecorator {

    public MoreWater(Coffee coffee) {
        super(coffee);
    }

    @Override
    public double getCost() {
        return super.getCost()+0.5;
    }

    @Override
    public String getDescription() {
        return super.getDescription()+" + More Water";
    }
}
