package statuses;

public interface Status {
    String getStatus();
    Status nextStatus();
}
