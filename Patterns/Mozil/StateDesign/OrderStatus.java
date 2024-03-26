import statuses.Status;

public class OrderStatus {
    private Status status;

    public OrderStatus(Status status) {
        this.status = status;
    }

    public void nextStatus() {
        status = status.nextStatus();
    }

    @Override
    public String toString() {
        return status.getStatus();
    }
}
