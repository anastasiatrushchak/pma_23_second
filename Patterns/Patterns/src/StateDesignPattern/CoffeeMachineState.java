package StateDesignPattern;

public abstract class CoffeeMachineState {
    protected CoffeeMachine coffeeMachine;

    public CoffeeMachineState(CoffeeMachine coffeeMachine) {
        this.coffeeMachine = coffeeMachine;
    }

    public abstract void makeOrder();
    public abstract void screen();
    public abstract void info();
    public abstract void cup();

    public void isMaking() {}
    public void isFree() {}
    public void stopMaking() {}
    public void startMaking() {}
}