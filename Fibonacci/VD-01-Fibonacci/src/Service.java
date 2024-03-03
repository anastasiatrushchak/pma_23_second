//import java.util.List;
//
//
//final class Service {
//    static Sequence calculate(List<Integer> Fibonacci, int MaxValue, int Counter) {
//        if (Fibonacci.get(Fibonacci.size() - 1) >= MaxValue) {
//            Sequence sequence = new Sequence();
//            sequence.setFibonacci(Fibonacci);
//            sequence.setMaxValue(Fibonacci.size());
//            return sequence;
//        }
//
//        Counter++;
//        int C = Fibonacci.get(Fibonacci.size() - 1) + Fibonacci.get(Fibonacci.size() - 2);
//        Fibonacci.add(C);
//        return calculate(Fibonacci, MaxValue, Counter);
//    }
//}

import java.util.ArrayList;
import java.util.List;
import java.util.zip.GZIPInputStream;

final class Service {
    static Sequence CalculateByBorder(List<Integer> Fibonacci, int MaxValue, int Counter) {
        if (Fibonacci.get(Fibonacci.size() - 1) + Fibonacci.get(Fibonacci.size() - 2) > MaxValue) {
            Sequence sequence = new Sequence();
            sequence.setFibonacci(Fibonacci);
            sequence.setMaxValue(Fibonacci.size());
            return sequence;
        }

        Counter++;
        int C = Fibonacci.get(Fibonacci.size() - 1) + Fibonacci.get(Fibonacci.size() - 2);

        List<Integer> newFibonacci = new ArrayList<>(Fibonacci);
        newFibonacci.add(C);

        return CalculateByBorder(newFibonacci, MaxValue, Counter);
    }

    /**
     * functoin calculate fibonacci number by count of iteration
     * @param Fibonacci it is a list of fibonacci number
     * @param CountFromUser it is number which the user enter and denotes the number of iterations
     * @param Counter it is variable which we need fo count number of fibonacci
     * @return
     */
    static Sequence CalculateByCount(List<Integer> Fibonacci, int CountFromUser, int Counter) {
        if (Counter >= CountFromUser) {
            Sequence sequence = new Sequence();
            sequence.setFibonacci(Fibonacci);
            return sequence;
        }

        Counter++;
        int C = Fibonacci.get(Fibonacci.size() - 1) + Fibonacci.get(Fibonacci.size() - 2);

        List<Integer> newFibonacci = new ArrayList<>(Fibonacci);
        newFibonacci.add(C);

        return CalculateByCount(newFibonacci, CountFromUser, Counter);
    }
}

