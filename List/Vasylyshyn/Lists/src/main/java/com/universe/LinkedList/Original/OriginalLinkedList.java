package main.java.com.universe.LinkedList.Original;

import java.util.LinkedList;

public class OriginalLinkedList {
    public static void main(String[] args) {
        LinkedList<Integer> list=new LinkedList<>();
        System.out.println(list);
        list.add(3);
        System.out.println(list);
        System.out.println(list.size());
        list.add(1);
        list.add(4);
        list.add(2);
        System.out.println(list);
        System.out.println(list.reversed());
        System.out.println(list);
    }
}
