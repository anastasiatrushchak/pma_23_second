import java.util.ArrayList;
import java.util.List;


public class Main {
    public static void main(String[] args) {
        System.out.println("\t\tRow by border (from constructor): ");
        List<Integer> listInt = new ArrayList<>();
        listInt.add(0);
        listInt.add(1);
        listInt.add(1);
        listInt.add(2);

        Fibonacci fibonacciByBorder = new Fibonacci(listInt);
        Fibonacci result = Service.getFibonacciRowByBorder(fibonacciByBorder, 300);
        System.out.println(result);

        System.out.println("\t\tSteps-limited row (from constructor): ");
        List<Integer> resultStep = Service.getFibonacciStepsLimitedRow(fibonacciByBorder, 15);
        System.out.println(resultStep);

        Fibonacci fibonacciFromFile = new Fibonacci("src/data.txt");
        System.out.println("\nRow from file: " + fibonacciFromFile + "\n");
        System.out.println("\t\tRow by border (from file): ");
        Fibonacci resultFromFile = Service.getFibonacciRowByBorder(fibonacciFromFile, 300);
        System.out.println(resultFromFile);

        System.out.println("\t\tSteps-limited row (from file): ");
        List<Integer> resultFromFileList = Service.getFibonacciStepsLimitedRow(fibonacciFromFile, 15);
        System.out.println(resultFromFileList);
    }
}
