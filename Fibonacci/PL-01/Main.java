package lnu;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        try (BufferedReader br = new BufferedReader(new FileReader("input.txt"))) {
            int first = Integer.parseInt(br.readLine());
            int second = Integer.parseInt(br.readLine());
            int limit = Integer.parseInt(br.readLine());

            FibonacciSequence fibonacci = new FibonacciSequence();
            FibonacciService.generateByLimit(fibonacci, limit, first, second);
            System.out.println("Ряд: " + String.join(" ", mapToStringList(fibonacci.getSequence())));
            System.out.println("Крокiв: " + fibonacci.getSteps());

            fibonacci = new FibonacciSequence();
            int steps = Integer.parseInt(br.readLine());
            FibonacciService.generateBySteps(fibonacci, steps, first, second);
            System.out.println("Ряд: " + String.join(" ", mapToStringList(fibonacci.getSequence())));
            System.out.println("Крокiв: " + fibonacci.getSteps());

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    private static List<String> mapToStringList(List<Integer> list) {
        List<String> stringList = new ArrayList<>();
        for (Integer i : list) {
            stringList.add(String.valueOf(i));
        }
        return stringList;
    }
}

