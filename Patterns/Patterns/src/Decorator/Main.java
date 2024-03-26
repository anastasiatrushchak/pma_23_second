package Decorator;

public class Main {
    public static void main(String[] args) {
        Coffee coffee = new SimpleCoffee();
        System.out.println(coffee.getDescription() + " $ " + coffee.getCost());



        coffee = new Croissants(coffee);
        System.out.println(coffee.getDescription() + " $ "  + coffee.getCost());
        coffee= new Milk(coffee);
        System.out.println(coffee.getDescription()+" $"+ coffee.getCost());
        coffee = new Milk(coffee);
        System.out.println(coffee.getDescription() + " $ "  + coffee.getCost());

        coffee = new Sugar(coffee);
        System.out.println(coffee.getDescription() + " $ " + coffee.getCost());
        coffee = new MoreWater(coffee);
        System.out.println(coffee.getDescription()+ " $ "+coffee.getCost());
    }
}

