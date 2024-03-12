import java.util.List;
public class Validate {
    public static void checkMatricesForAddSub(List<List<Double>> matrix1, List<List<Double>> matrix2) throws MatrixComparisonException {
        if (matrix1.size() != matrix2.size() || matrix1.get(0).size() != matrix2.get(0).size()) {
            throw new MatrixComparisonException("Матриці мають різні розміри.");
        }
    }
    public static void checkMatricesForMul(List<List<Double>> matrix1, List<List<Double>> matrix2) throws MatrixComparisonException {
        try {
            if (matrix1.size() != matrix2.get(0).size()) {
                throw new MatrixComparisonException("Довжина рядка першої матриці, повинна бути одинаковою з довжиною стовпчика другої матриці.");
            }
        } catch (IndexOutOfBoundsException e) {
            throw new MatrixComparisonException("Матриці повинні бути заповненими");
        }
    }
    public static void checkMatrixConsistency(List<List<Double>> matrix) throws MatrixComparisonException {
        if (matrix != null && matrix.size() > 0) {
            int cols = matrix.get(0).size();
            for (int i = 0; i < matrix.size(); i++) {
                List<Double> row = matrix.get(i);
                if (row.size() != cols) {
                    throw new MatrixComparisonException("Неправильна кількість елементів у рядку " + (i + 1) + " матриці.");
                }
            }
        }
    }
    public static void matrixIsEmpty(List<List<Double>> matrix) throws  MatrixComparisonException{
        if (matrix == null){
            throw new MatrixComparisonException("Матриці повинні бути заповненими");
        }
    }


}

