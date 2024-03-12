import java.util.Scanner;

public class Matrix {
    private int[][] matrix;
    private final int n;
    private final int m;

    public Matrix(int n, int m) {
        this.n = n;
        this.m = m;
    }

    public Matrix(int[][] matrix) {
        this.matrix = matrix;
        this.n = matrix.length;
        this.m = matrix[0].length;
    }

    public void matrixConsoleInput() {
        Scanner scanner = new Scanner(System.in);
        matrix = new int[n][m];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                System.out.print("Input [" + (i+1) + "] [" + (j+1) + "]: ");
                matrix[i][j] = Integer.parseInt(scanner.nextLine());
            }
        }
    }
    public void plus(Matrix other){
        int[][] otherMatrix = other.getMatrix();
        if (other.getN() == n && other.getM() == m) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    matrix[i][j] += otherMatrix[i][j];
                }
            }
        }else{
            System.err.println("Can't add matrix with other dimensions!");
        }
    }

    public void minus(Matrix other){
        int[][] otherMatrix = other.getMatrix();
        if (other.getN() == n && other.getM() == m) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    matrix[i][j] -= otherMatrix[i][j];
                }
            }
        }else{
            System.err.println("Can't subtract matrix with other dimensions!");
        }
    }


    public int[][] getMatrix() {
        return matrix;
    }

    public int getN() {
        return n;
    }

    public int getM() {
        return m;
    }

    @Override
    public String toString() {
        StringBuilder matrixStr = new StringBuilder();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                matrixStr.append(matrix[i][j]).append(" ");
            }
            matrixStr.append("\n");
        }
        return String.valueOf(matrixStr);
    }
}
