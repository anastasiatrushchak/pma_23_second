package lnu.edu.ua.singleton;

public class Main {

    public static void main(String[] args) {
        ConnectionManager connectionManager = ConnectionManager.getInstance("test1.com");
        System.out.println(connectionManager.toString());
        connectionManager.getConnectionStatus();
        ConnectionManager connectionManager2 = ConnectionManager.getInstance("test2.com");
        System.out.println(connectionManager2.toString());
        connectionManager2.getConnectionStatus();
    }
}