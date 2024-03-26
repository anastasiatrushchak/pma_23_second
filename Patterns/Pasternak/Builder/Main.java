package Pattern.Builder;

public class Main {
    public static void main(String[] args) {
        Pizza pizza1 = LaPizza.getMyPizza();
        System.out.println(pizza1);
        Pizza pizza2 = LaPizza.getMargarita();
        System.out.println(pizza2);

    }
}
