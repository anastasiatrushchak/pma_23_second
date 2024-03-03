import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public final class Reader {
    static List<Integer> list = new ArrayList<>();
    static Integer UsersNumber ;
    private static final BufferedReader bufferedReader;

    static {
        try {
            bufferedReader = new BufferedReader(new FileReader("Data.txt"));
        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        }
    }

    public static void readDataFromFile() throws IOException {

        String line = bufferedReader.readLine();

        list = Arrays.stream(line.split("\\s+")).map(Integer::parseInt).collect(Collectors.toList());
        line = bufferedReader.readLine();
        UsersNumber = Integer.parseInt(line.trim());
        System.out.println("User list: "+ list);
        System.out.println("User number: "+UsersNumber);
    }

}
