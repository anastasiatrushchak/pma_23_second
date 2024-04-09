package org.example.Predko_List.Predko;

public class Appl {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();

        if(list.isEmpty()){
            System.out.println("\u001B[31mThe linked list is empty\u001B[0m");
        }else{
            System.out.println("\u001B[32mThe linked list isn't empty\u001B[0m");
        }

        list.append(1);
        list.append(2);
        list.append(3);
        list.append(4);
        list.append(5);
        System.out.println("Linked List after append:");
        list.printList();

        list.appendFirst(10);
        System.out.println("Linked list after adding to the beginning:");
        list.printList();

        list.appendAtIndex(2,20);
        System.out.println("Linked list after adding by index:");
        list.printList();

        list.deleteLast();
        System.out.println("Linked List after deleting last element:");
        list.printList();

        list.deleteAtIndex(2);
        System.out.println("Linked List after deleting by index:");
        list.printList();

        list.replaceAtIndex(0, 0);
        System.out.println("Linked List after replacement:");
        list.printList();

        if(list.isEmpty()){
            System.out.println("\u001B[31mThe linked list is empty\u001B[0m");
        }else{
            System.out.println("\u001B[32mThe linked list isn't empty\u001B[0m");
        }

        int index = 2;
        System.out.println("Get " + (index+1) +" items from the linked list:\n" + list.get(index));

        list.clear();
        System.out.println("Linked list after clearing");
        if(list.isEmpty()){
            System.out.println("\u001B[31mThe linked list is empty\u001B[0m");
        }else{
            System.out.println("\u001B[32mThe linked list isn't empty\u001B[0m");
        }

    }
}