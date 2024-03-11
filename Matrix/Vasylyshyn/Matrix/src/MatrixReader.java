import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class MatrixReader {

    public static int[][] readMatrixFromFile(String fileName) {
        List<int[]> matrixList = new ArrayList<>();

        try {
            File file = new File(fileName);
            Scanner scanner = new Scanner(file);

            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                String[] values = line.trim().split("\\s+");

                int[] row = new int[values.length];
                boolean validRow = true;

                for (int i = 0; i < values.length; i++) {
                    try {
                        row[i] = Integer.parseInt(values[i]);
                    } catch (NumberFormatException e) {
                        System.out.println("Invalid number format in the file. Skipping the invalid value.");
                        validRow = false;
                        break;
                    }
                }

                if (validRow) {
                    matrixList.add(row);
                }
            }

            scanner.close();

            int numRows = matrixList.size();
            int numCols = (numRows > 0) ? matrixList.get(0).length : 0;

            for (int i = 1; i < numRows; i++) {
                if (matrixList.get(i).length != numCols) {
                    System.out.println("Invalid matrix format: Rows have different lengths.");
                    System.exit(1);

                }
            }

        } catch (FileNotFoundException e) {
            System.out.println("File not found: " + fileName);
        } catch (Exception e) {
            System.out.println("An error occurred: " + e.getMessage());
        }

        // Convert List<int[]> to int[][]
        int numRows = matrixList.size();
        int numCols = (numRows > 0) ? matrixList.get(0).length : 0;
        int[][] matrix = new int[numRows][numCols];

        for (int i = 0; i < numRows; i++) {
            matrix[i] = matrixList.get(i);
        }

        return matrix;
    }
}
