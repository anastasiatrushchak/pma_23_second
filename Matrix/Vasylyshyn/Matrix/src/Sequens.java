class Sequens {

    public static int[][] SummOfMatrix(int [][]FirstMatrix, int[][] SecondMatrix){
        int [][]ResulOfSumm = new int[FirstMatrix.length][SecondMatrix.length];
        for (int i = 0; i < SecondMatrix.length; i++) {
            for (int j = 0; j < FirstMatrix.length; j++) {
                ResulOfSumm[i][j]=FirstMatrix[i][j]+FirstMatrix[i][j];
            }
        }
        return ResulOfSumm;
    }

    public static int[][] SubstractionOfMatrix(int [][]FirstMatrix, int[][] SecondMatrix){
        int [][]ResulOfSumm = new int[FirstMatrix.length][SecondMatrix.length];
        for (int i = 0; i < SecondMatrix.length; i++) {
            for (int j = 0; j < FirstMatrix.length; j++) {
                ResulOfSumm[i][j]=FirstMatrix[i][j]-SecondMatrix[i][j];
            }
        }
        return ResulOfSumm;
    }
    public static int[][] MultiplicationOfMatrix(int [][] FirstMatrix, int [][] SecondMatrix){


        int [][] ResultOfMultiplication = new int[FirstMatrix.length][FirstMatrix.length];

        for (int i = 0; i < FirstMatrix.length; i++) {
            for (int j = 0; j < FirstMatrix.length; j++) {
                for (int k = 0; k < FirstMatrix.length; k++) {
                    ResultOfMultiplication[i][j] += FirstMatrix[i][k] * SecondMatrix[k][j];
                }
            }
        }

        return ResultOfMultiplication;
    }


}
