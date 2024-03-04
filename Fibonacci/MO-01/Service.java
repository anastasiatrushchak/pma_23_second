import java.util.ArrayList;
import java.util.List;

public class Service {
    public static Fibonacci getFibonacciRowByBorder(Fibonacci fibonacciRow, int limit) {
        return getFibonacciRowByBorder(fibonacciRow, limit, 0);
    }

    private static Fibonacci getFibonacciRowByBorder(Fibonacci fibonacciRow, int limit, int step) {
        final List<Integer> list = new ArrayList<>(fibonacciRow.getRow());
        final int newElement = list.get(list.size() - 2) + list.getLast();
        if (newElement < limit) {
            list.add(newElement);
            step++;
            return getFibonacciRowByBorder(new Fibonacci(list, step), limit, step);
        }
        return new Fibonacci(list, step);
    }

    public static List<Integer> getFibonacciStepsLimitedRow(Fibonacci fibonacciRow, int limit) {
        final List<Integer> list = new ArrayList<>(fibonacciRow.getRow());
        return getFibonacciStepsLimitedRow(list, limit, 0);
    }

    private static List<Integer> getFibonacciStepsLimitedRow(List<Integer> list, int limit, int step) {
        int newElement = list.get(list.size() - 2) + list.getLast();
        if (step != limit) {
            list.add(newElement);
            step++;
            return getFibonacciStepsLimitedRow(list, limit, step);
        }
        return list;
    }
}
