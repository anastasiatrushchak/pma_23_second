final class Matrix {
    static int MatrixSize;
    static int[][] FirstMatrix = new int[MatrixSize][MatrixSize];
    static int [][] SecondMatrix = new int[MatrixSize][MatrixSize];

    public static int getMatrixSize() {
        return MatrixSize;
    }

    public static void setMatrixSize(int matrixSize) {
        MatrixSize = matrixSize;
    }

    public static int[][] getFirstMatrix() {
        return FirstMatrix;
    }

    public static void setFirstMatrix(int[][] firstMatrix) {
        FirstMatrix = firstMatrix;
    }

    public static int[][] getSecondMatrix() {
        return SecondMatrix;
    }

    public static void setSecondMatrix(int[][] secondMatrix) {
        SecondMatrix = secondMatrix;
    }
}
