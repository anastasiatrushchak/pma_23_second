package lnu.edu.ua.command;

import java.sql.Driver;

public class Main {
    public static void main(String[] args) {
        DriverManager driverManager = new DriverManager();
        User user = new User(new ConnectCommand(driverManager),
                new GetCommand(driverManager),
                new UpdateCommand(driverManager),
                new PatchCommand(driverManager));

        user.doConnect();
        user.doGet();
        user.doUpdate();
        user.doPatch();
    }
}
