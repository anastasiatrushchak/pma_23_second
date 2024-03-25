package lnu.edu.ua.command;

public class User {
    Query connect;
    Query get;
    Query update;
    Query patch;

    public User(Query connect, Query get, Query update, Query patch) {
        this.connect = connect;
        this.get = get;
        this.update = update;
        this.patch = patch;
    }

    public void doConnect() {
        connect.execute();
    }

    public void doGet() {
        get.execute();
    }

    public void doUpdate() {
        update.execute();
    }

    public void doPatch() {
        patch.execute();
    }
}
