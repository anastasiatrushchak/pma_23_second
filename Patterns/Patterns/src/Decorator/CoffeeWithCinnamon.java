package Decorator;

import java.time.DayOfWeek;
import java.time.LocalDate;

public class CoffeeWithCinnamon extends CoffeeDecorator{
    public CoffeeWithCinnamon(Coffee coffee) {
        super(coffee);
    }

    @Override
    public double getCost() {
        if(LocalDate.now().getDayOfWeek().equals(DayOfWeek.THURSDAY)){
            return super.getCost()+5;
        }
        return super.getCost()*0;
    }

    @Override
    public String getDescription() {
        if(LocalDate.now().getDayOfWeek().equals(DayOfWeek.THURSDAY)){
            return super.getDescription()+" Oh it is Thursday i will make your order Coffee with Cinnamon";

        }
        return super.getDescription()+" It is not Thursday go away";
    }
}
