package StateDesignPattern;

public class CoffeeMachine {
    private CoffeeMachineState coffeeMachineState;

    public CoffeeMachine() {
        this.coffeeMachineState = new AwaitingOrder(this);
    }

    public void changeState(CoffeeMachineState coffeeMachineState){
        this.coffeeMachineState = coffeeMachineState;
    }

    public void makeOrder(){
        coffeeMachineState.makeOrder();
    }

    public void screen(){
        coffeeMachineState.screen();
    }

    public void info(){
        coffeeMachineState.info();
    }

    public void cup(){
        coffeeMachineState.cup();
    }

    public void isMaking() {
        coffeeMachineState.isMaking();
    }

    public void isFree() {
        coffeeMachineState.isFree();
    }

    public void stopMaking() {
        coffeeMachineState.stopMaking();
    }

    public void startMaking() {
        coffeeMachineState.startMaking();
    }

    public void Status(CoffeeMachine coffeeMachine) {
        coffeeMachine.screen();
        coffeeMachine.cup();
        coffeeMachine.info();
        coffeeMachine.makeOrder();
    }
}