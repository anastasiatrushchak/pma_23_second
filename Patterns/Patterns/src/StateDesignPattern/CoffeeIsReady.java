package StateDesignPattern;

public class CoffeeIsReady extends CoffeeMachineState {
    public CoffeeIsReady(CoffeeMachine coffeeMachine) {
        super(coffeeMachine);
    }

    @Override
    public void makeOrder() {
        System.out.println("Coffee is made");
    }

    @Override
    public void screen() {}

    @Override
    public void info() {
        System.out.println("You can take your order");
    }

    @Override
    public void cup() {}
}
