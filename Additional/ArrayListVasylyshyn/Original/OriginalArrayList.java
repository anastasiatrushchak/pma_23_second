package main.java.com.universe.ArrayList.Original;

import java.util.ArrayList;

public class OriginalArrayList {
    public static void main(String[] args) {
        ArrayList<Integer> listt = new ArrayList<>(3);
        System.out.println(listt.size());
        System.out.println(listt);
        listt.add(4);
        System.out.println(listt);
        System.out.println(listt.size());
        listt.add(5);
        System.out.println(listt);
        System.out.println(listt.size());
        System.out.println(listt.reversed());
    }
}
