class Main{
    public static void main(String[] args) {
        int [][]matrix1=MatrixReader.readMatrixFromFile("Data.txt");
        int [][]matrix2=MatrixReader.readMatrixFromFile("Data2.txt");
        int [][] matrix=Sequens.SummOfMatrix(matrix1,matrix2);
        for (int i = 0; i < matrix2.length; i++) {
            for (int j = 0; j <matrix2.length; j++) {
                System.out.print(matrix[i][j]+" ");
            }
            System.out.println();
        }
        System.out.println();
        int [][] matrixr=Sequens.SubstractionOfMatrix(matrix1,matrix2);
        for (int i = 0; i < matrix2.length; i++) {
            for (int j = 0; j <matrix2.length; j++) {
                System.out.print(matrixr[i][j]+" ");
            }
            System.out.println();
        }
        System.out.println();
        int [][] ResultOfMult=Sequens.MultiplicationOfMatrix(matrix1, matrix2);
        for (int i = 0; i < ResultOfMult.length; i++) {
            for (int j = 0; j <ResultOfMult.length; j++) {
                System.out.print(ResultOfMult[i][j]+" ");
            }
            System.out.println();
        }
    }
}