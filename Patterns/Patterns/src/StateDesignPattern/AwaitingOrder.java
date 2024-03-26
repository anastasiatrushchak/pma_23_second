package StateDesignPattern;

public class AwaitingOrder extends CoffeeMachineState {
    public AwaitingOrder(CoffeeMachine coffeeMachine) {
        super(coffeeMachine);
    }

    @Override
    public void makeOrder() {
        System.out.println("I wait for your order");
    }

    @Override
    public void screen() {
        System.out.println("Choose on the screen what type of coffee you need");
    }

    @Override
    public void info() {
        System.out.println("I will make you a coffee");
    }

    @Override
    public void cup() {
        System.out.println("Choose cup");
    }
}