package main.java.com.universe.ArrayList;

import main.java.com.universe.ArrayList.ArList.ArrList;
import main.java.com.universe.ArrayList.Interface.MyArrayList;

import java.util.ArrayList;

public class MyApp {
    public static void main(String[] args) {
        MyArrayList<Integer> list = new ArrList<>(6);
        ArrayList<Integer> list1 = new ArrayList<>();
        System.out.println(list);
        list1.add(300);
        list1.add(400);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);

        list.AddAll(list1);
        System.out.println(" size" + list.Size());
        System.out.println("List elements:");

        System.out.println();
        System.out.println();
        list.AddFirst(1000000);


        list.AddLast(999999);
        for (int i = 0; i < list.Size(); i++) {
            System.out.println(list.Get(i));
        }

        System.out.println(list);
        list.Add(4);
        System.out.println(list);
        list.Add(5);
        System.out.println(list);
        list.Add(7);
        System.out.println(list);
        list.Add(9);
        System.out.println(list);

    }
}
