import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Matrix {

    public static List<List<Double>> addMatrices(List<List<Double>> matrixA, List<List<Double>> matrixB) {
        List<List<Double>> result = new ArrayList<>();

        try {
            Validate.checkMatrixConsistency(matrixA);
            Validate.checkMatrixConsistency(matrixB);
            Validate.matrixIsEmpty(matrixA);
            Validate.matrixIsEmpty(matrixB);
            Validate.checkMatricesForAddSub(matrixA, matrixB);

            for (int i = 0; i < matrixA.size(); i++) {
                List<Double> rowResult = new ArrayList<>();
                for (int j = 0; j < matrixA.get(i).size(); j++) {
                    rowResult.add(matrixA.get(i).get(j) + matrixB.get(i).get(j));
                }
                result.add(rowResult);
            }
        } catch (MatrixComparisonException e) {
            System.out.println(e.getMessage());
        }
        return result;
    }

    public static List<List<Double>> subtractMatrices(List<List<Double>> matrixA, List<List<Double>> matrixB) {
        List<List<Double>> result = new ArrayList<>();

        try {
            Validate.checkMatrixConsistency(matrixA);
            Validate.checkMatrixConsistency(matrixB);
            Validate.matrixIsEmpty(matrixA);
            Validate.matrixIsEmpty(matrixB);
            Validate.checkMatricesForAddSub(matrixA, matrixB);

            for (int i = 0; i < matrixA.size(); i++) {
                List<Double> rowResult = new ArrayList<>();
                for (int j = 0; j < matrixA.get(i).size(); j++) {
                    rowResult.add(matrixA.get(i).get(j) - matrixB.get(i).get(j));
                }
                result.add(rowResult);
            }
        } catch (MatrixComparisonException e) {
            System.out.println(e.getMessage());
        }
        return result;
    }

    public static List<List<Double>> multiplyMatrices(List<List<Double>> matrixA, List<List<Double>> matrixB) {
        List<List<Double>> result = new ArrayList<>();

        try {
            Validate.checkMatrixConsistency(matrixA);
            Validate.checkMatrixConsistency(matrixB);
            Validate.matrixIsEmpty(matrixA);
            Validate.matrixIsEmpty(matrixB);
            Validate.checkMatricesForMul(matrixA, matrixB);

            for (int i = 0; i < matrixA.size(); i++) {
                List<Double> rowResult = new ArrayList<>();
                for (int j = 0; j < matrixB.get(0).size(); j++) {
                    double element = 0.0;
                    for (int k = 0; k < matrixA.get(0).size(); k++) {
                        element += matrixA.get(i).get(k) * matrixB.get(k).get(j);
                    }
                    rowResult.add(element);
                }
                result.add(rowResult);
            }
        } catch (MatrixComparisonException e) {
            System.out.println(e.getMessage());
        }
        return result;
    }


    public static void printMatrix(List<List<Double>> matrix) {
        try {
            Validate.checkMatrixConsistency(matrix);
            Validate.matrixIsEmpty(matrix);

            if (!matrix.isEmpty()) {
                for (List<Double> row : matrix) {
                    for (Double element : row) {
                        System.out.print(element + " ");
                    }
                    System.out.println();
                }
            }
        } catch (MatrixComparisonException e) {
            System.out.println(e.getMessage());
        } catch (RuntimeException e) {
            System.out.println(e.getMessage());
        }
    }


    public static List<List<Double>> readMatrixFromFile(String filePath) {
        List<List<Double>> matrix = new ArrayList<>();

        try {
            File file = new File(filePath);
            Scanner scanner = new Scanner(file);

            while (scanner.hasNextLine()) {
                List<Double> row = new ArrayList<>();
                String[] elements = scanner.nextLine().split("\\s+");

                for (String element : elements) {
                    try {
                        row.add(Double.parseDouble(element));
                    } catch (NumberFormatException e) {
                        System.out.println("Неправильний формат числа у файлі.");
                        return null;
                    }
                }

                matrix.add(row);
            }
            Validate.checkMatrixConsistency(matrix);
            scanner.close();
        } catch (FileNotFoundException e) {
            System.out.println("Файл не знайдено.");
            return null;
        } catch (MatrixComparisonException e) {
            System.out.println("Помилка порівняння матриць: " + e.getMessage());
            return null;
        }

        return matrix;
    }


}
