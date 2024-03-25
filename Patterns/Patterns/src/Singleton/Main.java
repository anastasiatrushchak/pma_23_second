package Singleton;

public class Main {
    public static void main(String[] args) throws CoffeeMachine.NotEnoughIngredientsException {
        CoffeeMachine coffeeMachine=CoffeeMachine.getInstance();
        System.out.println(coffeeMachine);
        coffeeMachine.RefreshCoffeeMachine(2, 2, 2, 2);
        System.out.println(coffeeMachine);
        coffeeMachine.MakeCoffee("Cappuccino");

        System.out.println(coffeeMachine);
        coffeeMachine.MakeCoffee("Espresso");
        coffeeMachine.MakeCoffee("Cappuccino");
        System.out.println(coffeeMachine);
        //
        CoffeeMachine coffeeMachine1=CoffeeMachine.getInstance();
        coffeeMachine1.MakeCoffee("Cappuccino");
        System.out.println(coffeeMachine1);
    }
}
