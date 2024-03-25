package StateDesignPattern;

public class Main {
    public static void main(String[] args) {
        CoffeeMachine coffeeMachine = new CoffeeMachine();

        coffeeMachine.makeOrder();
        coffeeMachine.Status(coffeeMachine);
        System.out.println();
        coffeeMachine.changeState(new CoffeeIsReady(coffeeMachine));
        coffeeMachine.Status(coffeeMachine);
    }
}
