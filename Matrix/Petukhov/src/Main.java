import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Matrix matrixA = new Matrix();
        Matrix matrixB = new Matrix();

        try (BufferedReader br = new BufferedReader(new FileReader("./resources/matrix_a.txt"))) {
            List<List<Double>> data = new ArrayList<>();
            String line;

            while ((line = br.readLine()) != null) {
                List<Double> row = new ArrayList<>();
                String[] elements = line.split(" ");
                for (String element : elements) {
                    row.add(Double.parseDouble(element));
                }
                data.add(row);
            }

            matrixA.setData(data);
            matrixA.setRows(data.size());
            matrixA.setColumns(data.getFirst().size());
        } catch (IOException e) {
            System.out.println("File not found");
        }

        try (BufferedReader br = new BufferedReader(new FileReader("./resources/matrix_b.txt"))) {
            List<List<Double>> data = new ArrayList<>();
            String line;

            while ((line = br.readLine()) != null) {
                List<Double> row = new ArrayList<>();
                String[] elements = line.split(" ");
                for (String element : elements) {
                    row.add(Double.parseDouble(element));
                }
                data.add(row);
            }

            matrixB.setData(data);
            matrixB.setRows(data.size());
            matrixB.setColumns(data.getFirst().size());
        } catch (IOException e) {
            System.out.println("File not found");
        }

        System.out.println(matrixA);
        System.out.println(MatrixUtil.add(matrixA, matrixA));
        System.out.println(MatrixUtil.subtract(matrixA, matrixA));
        System.out.println(MatrixUtil.multiply(matrixA, matrixA));
        // catch error
        System.out.println(MatrixUtil.add(matrixA, matrixB));
    }
}