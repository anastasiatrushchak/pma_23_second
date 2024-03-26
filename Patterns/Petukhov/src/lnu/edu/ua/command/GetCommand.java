package lnu.edu.ua.command;

public class GetCommand implements Query {
    private DriverManager driverManager;

    public GetCommand(DriverManager driverManager) {
        this.driverManager = driverManager;
    }

    @Override
    public void execute() {
        driverManager.get();
    }
}
