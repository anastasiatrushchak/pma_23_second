package ua.edu.lnu.util;

import ua.edu.lnu.model.LinkedList;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class LinkedListUtil<T> {
    public static <T> LinkedList<T> merge(LinkedList<T> list1, LinkedList<T> list2) {
        LinkedList<T> result = new LinkedList<>();
        for (int i = 0; i < list1.size(); i++) {
            result.add(list1.get(i));
        }
        for (int i = 0; i < list2.size(); i++) {
            result.add(list2.get(i));
        }
        return result;
    }

    public static <T> LinkedList<T> reverse(LinkedList<T> list) {
        LinkedList<T> result = new LinkedList<>();
        for (int i = list.size() - 1; i >= 0; i--) {
            result.add(list.get(i));
        }
        return result;
    }

    public static <T> void printList(LinkedList<T> list) {
        for (int i = 0; i < list.size(); i++) {
            System.out.println(list.get(i));
        }
    }

    public static <T> void writeToFile(LinkedList<T> list, String filename) {
        try (PrintWriter writer = new PrintWriter(filename)) {
            for (int i = 0; i < list.size(); i++) {
                writer.println(list.get(i));
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

    public static LinkedList<Integer> readFromFile(String filename) {
        LinkedList<Integer> list = new LinkedList<>();
        try (Scanner scanner = new Scanner(new File(filename))) {
            while (scanner.hasNextInt()) {
                list.add(scanner.nextInt());
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return list;
    }
}