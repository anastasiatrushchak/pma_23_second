package main.java.com.universe.ArrayList;

import main.java.com.universe.ArrayList.ArList.ArrList;
import main.java.com.universe.ArrayList.Interface.MyArrayList;

import java.util.ArrayList;

public class MyApp {
    public static void main(String[] args) {
        MyArrayList<Integer> list = new ArrList<>(8);
        ArrayList<Integer> list1 = new ArrayList<>();
        System.out.println(list);

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);
        list.Add(7);
        list.Add(8);
        list.Remove(6);
        list.AddAll(list1);
        System.out.println(" size" + list.Size());
        System.out.println("List elements:");

        System.out.println();
        System.out.println();

        list.Add(1000);
        list.Add(999999);
        for (int i = 0; i < list.Size(); i++) {
            System.out.println(list.Get(i));
        }



    }
}
