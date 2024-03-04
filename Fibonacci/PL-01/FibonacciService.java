package lnu;

public class FibonacciService {
    public static void generateByLimit(FibonacciSequence fibonacci, int limit, int first, int second) {
        if (first > limit) {
            return;
        }

        fibonacci.getSequence().add(first);

        if (fibonacci.getSequence().size() > 2) {
            fibonacci.setSteps(fibonacci.getSteps() + 1);
        }

        generateByLimit(fibonacci, limit, second, first + second);
    }

    public static void generateBySteps(FibonacciSequence fibonacci, int steps, int first, int second) {
        if (fibonacci.getSteps() >= steps) {
            return;
        }

        fibonacci.getSequence().add(first);

        if (fibonacci.getSequence().size() > 2) {
            fibonacci.setSteps(fibonacci.getSteps() + 1);
        }

        generateBySteps(fibonacci, steps, second, first + second);
    }
}