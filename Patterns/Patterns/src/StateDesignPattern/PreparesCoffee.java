package StateDesignPattern;

public class PreparesCoffee extends CoffeeMachineState {
    public PreparesCoffee(CoffeeMachine coffeeMachine) {
        super(coffeeMachine);
    }

    @Override
    public void makeOrder() {
        System.out.println("I am making coffee for you");
    }

    @Override
    public void screen() {
        System.out.println("Screen is locked now");
    }

    @Override
    public void info() {
        System.out.println("I make a coffee");
    }

    @Override
    public void cup() {}
}