package FibonacciAlgorithmSteps;


import java.io.*;
import java.util.List;

import static FibonacciAlgorithmSteps.FibonachiService.getFiboncciByBorder;
import static FibonacciAlgorithmSteps.FibonachiService.getFiboncciByStep;

public class Main {
    public static void main(String[] args) {
//        int[] listInt ={0,1};
//        Fibonacci fibonacci = new Fibonacci(listInt);
//        System.out.println(fibonacci);
//        Fibonacci result = getFiboncciByBorder(fibonacci, 108);
//        System.out.println(result);
//        List<Integer> resultStep = getFiboncciByStep(fibonacci, 10);
//        System.out.println(resultStep);

        System.out.println("<------------------------------->");

        Fibonacci fibonacciFromFile = new Fibonacci("src/FibonacciAlgorithmSteps/file.txt");
        System.out.println("Початковий ряд: "+ fibonacciFromFile);
        Fibonacci resultFromFile = getFiboncciByBorder(fibonacciFromFile, 108);
        System.out.println(resultFromFile);

        List<Integer> resultFromFileList = getFiboncciByStep(fibonacciFromFile, 11);
        System.out.println(resultFromFileList);
        System.out.println("Початковий ряд: "+ fibonacciFromFile);
    }
}
