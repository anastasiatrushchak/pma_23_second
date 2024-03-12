public class Util {
    public static Matrix multiply(Matrix a, Matrix b){

        if (a.getN() == b.getM()){
            int [][] result = new int[a.getN()][b.getM()];
            for (int i = 0; i < result.length; i++){
                for (int j = 0; j < result[0].length; j++){
                    result[i][j] = 0;
                    for (int k = 0; k < a.getM(); k++){
                        result[i][j] += a.getMatrix()[i][k] * b.getMatrix()[k][j];
                    }
                }
            }
            return new Matrix(result);
        }else{
            System.err.println("Can't multiply matrix with other dimensions!");
            return null;
        }
    }
}
