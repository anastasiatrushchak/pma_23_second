package statuses;

public class Delivering implements Status {
    public String getStatus() {
        return "Delivering";
    }

    @Override
    public Status nextStatus() {
        return new Delivered();
    }
}
