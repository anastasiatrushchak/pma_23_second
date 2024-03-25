package lnu.edu.ua.command;

public class ConnectCommand implements Query {
    private DriverManager driverManager;

    public ConnectCommand(DriverManager driverManager) {
        this.driverManager = driverManager;
    }

    @Override
    public void execute() {
        driverManager.connect();
    }
}
