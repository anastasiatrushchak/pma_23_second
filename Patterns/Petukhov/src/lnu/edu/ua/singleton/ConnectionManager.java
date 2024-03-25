package lnu.edu.ua.singleton;

public class ConnectionManager {
    private static ConnectionManager connectionManager;
    private static String url;

    private ConnectionManager(String url) {
        ConnectionManager.url = url;
    }

    public static synchronized ConnectionManager getInstance(String url) {
        if (connectionManager == null) {
            connectionManager = new ConnectionManager(url);
        }

        return connectionManager;
    }

    public void getConnectionStatus() {
        System.out.printf("Connection to %s is active\n", url);
    }
}
