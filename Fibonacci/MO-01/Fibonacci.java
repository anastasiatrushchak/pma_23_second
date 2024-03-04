import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

public class Fibonacci {
    private List<Integer> row;
    private int steps;

    public Fibonacci(List<Integer> row, int steps) {
        this.row = row;
        this.steps = steps;
    }

    public Fibonacci(List<Integer> row) {
        this.row = row;
        this.steps = 0;
    }

    public Fibonacci(String fileName) {
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
            System.err.println("File not found!");
            e.printStackTrace();
        }
        String line = lines.getFirst();
        line = line.substring(1, line.length() - 1);
        String[] elements = line.split(",\\s*");
        row = new ArrayList<>();
        for (String element : elements) {
            int num = Integer.parseInt(element);
            row.add(num);
        }
    }

    public List<Integer> getRow() {
        return row;
    }

    @Override
    public String toString() {
        return "row: " + row +
                ", steps: " + steps;
    }

}
