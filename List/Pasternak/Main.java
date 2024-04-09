package lnu.com.list;

import lnu.com.list.MyList.MyList;
import lnu.com.list.MyList.myListImpl.MyArrayList;
import lnu.com.list.MyList.myListImpl.MyLinkedList;

public class Main {
    public static void main(String[] args) {
//        Integer[] arr = {1,2,3,4,5};
//        MyList<Integer> mylist = new MyLinkedList<>(1,2,3,4,5);

//        mylist.stream().forEach(System.out::println);
//
//        System.out.println("Заповнили: " + mylist);
//
//        mylist.add(0, 0);
////        mylist.add(0, 90);
//        mylist.add(0, 6);
//        mylist.add(0, 2);
//        System.out.println("Добавили по індексу: " + mylist);
//
//        mylist.remove(0);
////        mylist.remove(90);
//        mylist.remove(6);
//        mylist.remove(1);
//        System.out.println("Видалили по індексу: " + mylist);
//
//        mylist.deleteAll();
//        System.out.println("Очистили: " + mylist);
//
//        mylist.add(1);
//        mylist.add(2);
//        System.out.println("Заповнили: " + mylist);
//
//        System.out.println("Метод get: " + mylist.get(1));

        MyArrayList<Integer> mylist = new MyArrayList<>(8);
        mylist.add(1);
        mylist.add(2);
        mylist.add(3);
        mylist.add(4);
        mylist.add(5);
        mylist.add(6);
        mylist.add(7);
        mylist.add(8);

        System.out.println(mylist + " "+ mylist.getCapacity() +" " +  mylist.getSize());
        mylist.add(9);
        System.out.println(mylist + " "+ mylist.getCapacity() +" " +  mylist.getSize());
        mylist.remove(0);
        mylist.remove(1);
        System.out.println(mylist + " "+ mylist.getCapacity() +" " +  mylist.getSize());

    }
}
