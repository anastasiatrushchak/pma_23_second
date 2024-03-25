package Singleton;

import java.time.LocalDate;

public class CoffeeMachine {
    private static CoffeeMachine instance;
    private int CountOfCoffee;
    private int CountOfMilk;
    private int CountOfSugar;
    private int CountOfWater;
    private LocalDate LastRefreshData;

    private CoffeeMachine() {
        CountOfCoffee = 0;
        CountOfMilk = 0;
        CountOfSugar = 0;
        CountOfWater = 0;
        LastRefreshData = null;
    }

    public static CoffeeMachine getInstance() {
        if (instance == null) {
            instance = new CoffeeMachine();
        }
        return instance;
    }

    public void MakeCoffee(String TypeOfCoffee) throws NotEnoughIngredientsException {
        switch (TypeOfCoffee) {
            case "Americano":
                if (CountOfCoffee < 1 || CountOfSugar < 1 || CountOfWater < 1)
                    throw new NotEnoughIngredientsException("Not enough ingredients to make Americano");
                CountOfCoffee--;
                CountOfSugar--;
                CountOfWater--;
                break;

            case "Espresso":
                if (CountOfCoffee < 2 || CountOfWater < 1)
                    throw new NotEnoughIngredientsException("Not enough ingredients to make Espresso");
                CountOfCoffee -= 2;
                CountOfWater--;
                break;

            case "Cappuccino":
                if (CountOfCoffee < 1 || CountOfSugar < 1 || CountOfWater < 1 || CountOfMilk < 1)
                    throw new NotEnoughIngredientsException("Not enough ingredients to make Cappuccino");
                CountOfCoffee--;
                CountOfSugar--;
                CountOfWater--;
                CountOfMilk--;
                break;
            default:
                break;
        }
    }

    public void RefreshCoffeeMachine(int Coffee, int Sugar, int Water, int Milk) throws IllegalArgumentException {
        if (Coffee < 0 || Sugar < 0 || Water < 0 || Milk < 0) {
            throw new IllegalArgumentException("Negative values are not allowed");
        }

        CountOfCoffee += Coffee;
        CountOfMilk = Milk;
        CountOfWater += Water;
        CountOfSugar += Sugar;
        LastRefreshData = LocalDate.now();
    }

    @Override
    public String toString() {
        return "CoffeeMachine{" +
                "CountOfCoffee=" + CountOfCoffee +
                ", CountOfMilk=" + CountOfMilk +
                ", CountOfSugar=" + CountOfSugar +
                ", CountOfWater=" + CountOfWater +
                ", LastRefreshData=" + LastRefreshData +
                '}';
    }

    public int getCountOfCoffee() {
        return CountOfCoffee;
    }

    public int getCountOfMilk() {
        return CountOfMilk;
    }

    public int getCountOfSugar() {
        return CountOfSugar;
    }

    public int getCountOfWater() {
        return CountOfWater;
    }

    public LocalDate getLastRefreshData() {
        return LastRefreshData;
    }

    public static class NotEnoughIngredientsException extends Exception {
        public NotEnoughIngredientsException(String message) {
            super(message);
        }
    }
}
