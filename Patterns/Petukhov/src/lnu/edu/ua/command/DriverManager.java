package lnu.edu.ua.command;

import java.util.ArrayList;
import java.util.List;

public class DriverManager {

    public void connect(){
        System.out.println("Connecting to the database...");
    }

    public void get(){
        System.out.println("Getting data from the database...");
    }

    public void update(){
        System.out.println("Updating data in the database...");
    }

    public void patch() {
        System.out.println("Patching data in the database...");
    }

    public void delete() {
        System.out.println("Deleting data from the database...");
    }
}
