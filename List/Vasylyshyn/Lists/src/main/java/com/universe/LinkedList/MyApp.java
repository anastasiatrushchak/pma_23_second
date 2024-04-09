package main.java.com.universe.LinkedList;

import main.java.com.universe.LinkedList.Original.LinkyList;


public class MyApp {

    public static void main(String[] args) {
        LinkyList<Integer> listt = new LinkyList<>();

        listt.AddLast(2);
        listt.AddLast(4);
        listt.AddFirst(0);
        listt.AddLast(6);
        listt.Add(8);
        listt.Add(10);
        listt.AddFirst(-2);
        listt.Add(12);
        System.out.println(listt);
        System.out.println("Size="+listt.GetSize());
        listt.GetAll();

        System.out.println(" skjbgerlg  "+listt.GetId(0));
        System.out.println("first is "+listt.GetFirst());
        listt.Remove(7);
        System.out.println("delete 0");
        listt.GetAll();
        System.out.println(listt.Size);
        listt.RemoveAll();
        System.out.println(listt);
        listt.GetAll();
    }
}
