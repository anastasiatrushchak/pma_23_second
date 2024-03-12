import java.util.List;

public class Main {
    public static void main(String[] args) {
        String matrixAFilePath = "/Users/lev/Desktop/annotations/src/Predko/matrixA.txt";
        String matrixBFilePath = "/Users/lev/Desktop/annotations/src/Predko/matrixB.txt";

        List<List<Double>> matrixA = Matrix.readMatrixFromFile(matrixAFilePath);
        List<List<Double>> matrixB = Matrix.readMatrixFromFile(matrixBFilePath);

        System.out.println("Matrix A:");
        Matrix.printMatrix(matrixA);

        System.out.println("\nMatrix B:");
        Matrix.printMatrix(matrixB);

        System.out.println("\nAddition (A + B):");
        List<List<Double>> sum = Matrix.addMatrices(matrixA, matrixB);
        Matrix.printMatrix(sum);

        System.out.println("\nSubtraction (A - B):");
        List<List<Double>> difference = Matrix.subtractMatrices(matrixA, matrixB);
        Matrix.printMatrix(difference);

        System.out.println("\nMultiplication (A * B):");
        List<List<Double>> product = Matrix.multiplyMatrices(matrixA, matrixB);
        Matrix.printMatrix(product);
    }
}
