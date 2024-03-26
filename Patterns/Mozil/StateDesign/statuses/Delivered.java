package statuses;

public class Delivered implements Status {
    public String getStatus() {
        return "Delivered";
    }

    @Override
    public Status nextStatus() {
        return this;
    }
}
