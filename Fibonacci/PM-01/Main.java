import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) throws IOException {
        ArrayList<Integer> list = new ArrayList<>();
        list.add(0);
        list.add(1);

        // borderAlg
        Sequence fsBorder = new Sequence(list);
        int border = 108;

        Service.borderAlg(border, fsBorder);
        System.out.println(fsBorder);

        // stepsAlg
        try {
            BufferedReader reader = new BufferedReader(new FileReader("/Users/pe_maksutka/IdeaProjects/fibonacciSequence/src/input.txt"));

            String line = null;

            while ((line = reader.readLine()) != null) {
                String[] parts = line.split("; ");
                int steps = Integer.parseInt(parts[0]);
                String[] elements = parts[1].split(",");

                ArrayList<Integer> list2 = new ArrayList<>();
                for (String element : elements) {
                    list2.add(Integer.parseInt(element));
                }

                Sequence fsSteps = new Sequence(list);

                Service.stepsAlg(steps, fsSteps);
                System.out.println(fsSteps.printSequence());
            }
        } catch (FileNotFoundException e) {
            System.out.println("File not found!");;
        }
    }
}