package lnu.edu.ua.command;

public class PatchCommand implements Query {
    private DriverManager driverManager;

    public PatchCommand(DriverManager driverManager) {
        this.driverManager = driverManager;
    }

    @Override
    public void execute() {
        driverManager.patch();
    }
}
