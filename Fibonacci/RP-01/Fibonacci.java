package FibonacciAlgorithmSteps;

//import Fibonacci_Algorithm_Boundary.NegativeNumberException;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;


public class Fibonacci {
    final private  List<Integer> list;
    private int step;

    public Fibonacci(String fileName){
        String projectDirectory = System.getProperty("user.dir");
        String filePath = projectDirectory + File.separator + fileName;
        List<String> lines = new ArrayList<>();
        try {
            File file = new File(fileName);
            Scanner scanner = new Scanner(file);

            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                lines.add(line);
            }
            scanner.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        String line = lines.get(0);
        line = line.substring(1, line.length() - 1);
        String[] elements = line.split(",\\s*");
        list = new ArrayList<>();
        for (String element : elements) {
            int num = Integer.parseInt(element);
            list.add(num);
        }
    }
    public Fibonacci(int[] list) {
        this.list = new ArrayList<>();
        step = 0;
        for(int i = 0; i<list.length; i++){
            this.list.add(list[i]);
        }
    }

    public Fibonacci(List<Integer> list, int step) {
        this.list = list;
        this.step = step;
    }
    public Fibonacci(List<Integer> list) {
        this.list = list;
        this.step = 0;
    }

    public List<Integer> getList() {
        return list;
    }

    @Override
    public String toString() {
        return "Fibonacci{" +
                "list=" + list +
                ", step=" + step +
                '}';
    }

}





//    @Override
//    public String toString() throws NegativeNumberException {
//
//        if (firstElement < 0 || secondElement < 0 || limit < 0) {
//            throw new NegativeNumberException();
//        }
//        step = 0;
//        List<Integer> fibonacciSequence = getFibonacci(new ArrayList<>(Arrays.asList(firstElement, secondElement)));
//        return fibonacciSequence.toString() + " ---> " + step;
//    }







//    public List<Integer> getListFibonacciBySteps() {
//        if (firstElement < 0 || secondElement < 0 || limit < 0) {
//            throw new NegativeNumberException();
//        }
//        step = 0;
//        List<Integer> fibonacciSequence = getFibonacci(new ArrayList<>(Arrays.asList(firstElement, secondElement)));
//        return fibonacciSequence ;
//    }