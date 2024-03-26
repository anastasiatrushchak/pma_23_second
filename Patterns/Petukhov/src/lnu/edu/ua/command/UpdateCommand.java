package lnu.edu.ua.command;

public class UpdateCommand implements Query {
    private DriverManager driverManager;

    public UpdateCommand(DriverManager driverManager) {
        this.driverManager = driverManager;
    }

    @Override
    public void execute() {
        driverManager.update();
    }
}
