import statuses.Cooking;

public class Main {
    public static void main(String[] args) {
        OrderStatus orderStatus = new OrderStatus(new Cooking());
        System.out.println(orderStatus);
        orderStatus.nextStatus();
        System.out.println(orderStatus);
        orderStatus.nextStatus();
        System.out.println(orderStatus);
    }
}
