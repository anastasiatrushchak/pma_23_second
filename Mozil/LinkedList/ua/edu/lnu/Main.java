package ua.edu.lnu;

import ua.edu.lnu.model.LinkedList;
import ua.edu.lnu.util.LinkedListUtil;

public class Main {
    public static void main(String[] args) {
//        LinkedList<Integer> linkedList = new LinkedList<>();
//        linkedList.add(1);
//        linkedList.add(2);
//        linkedList.add(3);
//
//        System.out.println("Original list:");
//        LinkedListUtil.printList(linkedList);
//
//        LinkedList<Integer> reversedList = LinkedListUtil.reverse(linkedList);
//        System.out.println("Reversed list:");
//        LinkedListUtil.printList(reversedList);
//
//        LinkedList<Integer> mergedList = LinkedListUtil.merge(linkedList, reversedList);
//        System.out.println("Merged list:");
//        LinkedListUtil.printList(mergedList);
//
//        LinkedList<Integer> fromFile = LinkedListUtil.readFromFile("src/main/java/ua/edu/lnu/txt/testList.txt");
//        System.out.println("List from file:");
//        LinkedListUtil.printList(fromFile);
//
//        LinkedListUtil.writeToFile(LinkedListUtil.reverse(fromFile),"src/main/java/ua/edu/lnu/txt/reversedListFromFile.txt");
        LinkedList<Integer> linkedList = new LinkedList<>();
        linkedList.add(1);
        linkedList.add(2);
        linkedList.add(3);
        linkedList.add(4);
        linkedList.add(3, 5);
        linkedList.remove(4);
        linkedList.add(2);
        linkedList.add(3);



    }
}
