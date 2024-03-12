import java.util.ArrayList;
import java.util.List;

public class MatrixUtil {

    public static Matrix add(Matrix matrix1, Matrix matrix2) {
        try {
            if (matrix1.getRows() != matrix2.getRows() || matrix1.getColumns() != matrix2.getColumns()) {
                throw new MatrixArithmeticException("Matrices must have the same dimensions");
            }

            Matrix result = new Matrix();
            result.setRows(matrix1.getRows());
            result.setColumns(matrix1.getColumns());

            for (int i = 0; i < matrix1.getRows(); i++) {
                List<Double> row = new ArrayList<>();
                for (int j = 0; j < matrix1.getColumns(); j++) {
                    row.add(matrix1.getElement(i, j) + matrix2.getElement(i, j));
                }
                result.getData().add(row);
            }

            return result;
        } catch (MatrixArithmeticException e) {
            System.out.println(e.getMessage());
            return null;
        }
    }

    public static Matrix subtract(Matrix matrix1, Matrix matrix2) {
        try {
            if (matrix1.getRows() != matrix2.getRows() || matrix1.getColumns() != matrix2.getColumns()) {
                throw new MatrixArithmeticException("Matrices must have the same dimensions");
            }

            Matrix result = new Matrix();
            result.setRows(matrix1.getRows());
            result.setColumns(matrix1.getColumns());

            for (int i = 0; i < matrix1.getRows(); i++) {
                List<Double> row = new ArrayList<>();
                for (int j = 0; j < matrix1.getColumns(); j++) {
                    row.add(matrix1.getElement(i, j) - matrix2.getElement(i, j));
                }
                result.getData().add(row);
            }

            return result;
        } catch (MatrixArithmeticException e) {
            System.out.println(e.getMessage());
            return null;
        }
    }

    public static Matrix multiply(Matrix matrix1, Matrix matrix2) {
        try {
            if (matrix1.getColumns() != matrix2.getRows()) {
                throw new MatrixArithmeticException("Number of columns in the first matrix must be equal" +
                        " to the number of rows in the second matrix");
            }

            Matrix result = new Matrix();
            result.setRows(matrix1.getRows());
            result.setColumns(matrix2.getColumns());

            for (int i = 0; i < matrix1.getRows(); i++) {
                List<Double> row = new ArrayList<>();
                for (int j = 0; j < matrix2.getColumns(); j++) {
                    double sum = 0;
                    for (int k = 0; k < matrix1.getColumns(); k++) {
                        sum += matrix1.getElement(i, k) * matrix2.getElement(k, j);
                    }
                    row.add(sum);
                }
                result.getData().add(row);
            }

            return result;
        } catch (MatrixArithmeticException e) {
            System.out.println(e.getMessage());
            return null;
        }
    }

    public static Matrix divide(Matrix matrix1, Matrix matrix2) {
        return null; // TODO: update
    }
}