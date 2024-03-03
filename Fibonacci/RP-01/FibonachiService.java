package FibonacciAlgorithmSteps;

import java.util.ArrayList;
import java.util.List;

public class FibonachiService {
    private static Fibonacci getFiboncciByBorder(
            final Fibonacci fibonacci,
            final int limit,
            int step){

        final List<Integer> list = new ArrayList<>(fibonacci.getList());
        final int newElement = list.get(list.size() - 2) + list.get(list.size() - 1);
        if (newElement < limit){
            list.add(newElement);
            step++;
            return getFiboncciByBorder(new Fibonacci(list, step),limit, step);
        }
        return new Fibonacci(list, step);
    }
    public static Fibonacci getFiboncciByBorder(final Fibonacci fibonacci, final int limit){
        return getFiboncciByBorder(fibonacci, limit, 0);
    }
    private static List<Integer> getFiboncciByStep(
            final List<Integer> list,
            final int limit,
            int step){

        final int newElement = list.get(list.size() - 2) + list.get(list.size() - 1);
        if (step != limit){
            list.add(newElement);
            step++;
//            System.out.println(step+"-> "+ list);

            return getFiboncciByStep(list, limit, step);
        }
//        System.out.println(step);
        return list;
    }
    public static List<Integer> getFiboncciByStep(final Fibonacci fibonacci, final int limit){
        final List<Integer> list = new ArrayList<>(fibonacci.getList());
        return getFiboncciByStep(list, limit, 0);
    }


}
