import java.io.*;

public class Main {

    public static void main(String[] args) throws IOException {
        Sequence sequence = new Sequence();
        Reader.readDataFromFile();
        sequence = Service.CalculateByBorder(Reader.list, Reader.UsersNumber, 0);
        System.out.println("Fibonacci by Border: " + sequence.getFibonacci());
        System.out.println("Number of steps: " + sequence.getMaxValue());
        sequence = Service.CalculateByCount(Reader.list, Reader.UsersNumber, 0);
        System.out.println("Fibonacci by counter: " + sequence.getFibonacci());

    }
}

