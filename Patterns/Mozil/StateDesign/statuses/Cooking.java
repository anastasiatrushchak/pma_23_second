package statuses;

public class Cooking implements Status {
    public String getStatus() {
        return "Cooking";
    }

    @Override
    public Status nextStatus() {
        return new Delivering();
    }
}
