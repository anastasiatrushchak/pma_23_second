package Pattern.Builder;

public class LaPizza {
    public static Pizza getMargarita(){
        return  Pizza.base()
                .addCheese("Mozzarella")
                .addMeat("Salami")
                .build();
    }
    public static Pizza getMyPizza(){
        return  Pizza.base()
                .addCheese("Mozzarella")
                .addMeat("Pepperoni")
                .addVegetable("Mushrooms")
                .addSeafood("Shrimp")
                .build();
    }

}
