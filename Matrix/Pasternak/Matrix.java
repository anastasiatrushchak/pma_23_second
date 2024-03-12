
import java.util.Random;

public class Matrix {
    private int[][] matrix;
    private int row;
    private int column;

    public Matrix(int row, int column) {
        this.row = row;
        this.column = column;
        Random random = new Random();
        this.matrix = new int[this.row][this.column];

        for(int i = 0; i < row; ++i) {
            for(int j = 0; j < column; ++j) {
                this.matrix[i][j] = random.nextInt(10);
            }
        }

    }

    public Matrix(int[][] matrix) {
        this.matrix = matrix;
        this.row = matrix.length;
        this.column = matrix[0].length;
    }

    public Matrix add(Matrix o) {
        if (this.row == o.row && this.column == o.column) {
            int[][] newMatrix = new int[this.row][this.column];

            for(int i = 0; i < this.row; ++i) {
                for(int j = 0; j < this.column; ++j) {
                    newMatrix[i][j] = this.matrix[i][j] + o.matrix[i][j];
                }
            }

            return new Matrix(newMatrix);
        } else {
            throw new SizeException();
        }
    }

    public Matrix subtract(Matrix o) {
        if (this.row == o.row && this.column == o.column) {
            int[][] newMatrix = new int[this.row][this.column];

            for(int i = 0; i < this.row; ++i) {
                for(int j = 0; j < this.column; ++j) {
                    newMatrix[i][j] = this.matrix[i][j] - o.matrix[i][j];
                }
            }

            return new Matrix(newMatrix);
        } else {
            throw new SizeException();
        }
    }

    public Matrix multiply(Matrix o) {
        if (this.column != o.row) {
            System.out.println("123");
            throw new SizeException();
        } else {
            int[][] newMatrix = new int[this.row][this.column];

            for(int i = 0; i < this.row; ++i) {
                for(int j = 0; j < this.column; ++j) {
                    for(int k = 0; k < this.column; ++k) {
                        newMatrix[i][j] += this.matrix[i][k] * o.matrix[k][j];
                    }
                }
            }

            return new Matrix(newMatrix);
        }
    }

    public String toString() {
        StringBuilder str = new StringBuilder();

        for(int i = 0; i < this.row; ++i) {
            for(int j = 0; j < this.column; ++j) {
                str.append(this.matrix[i][j]).append(" ");
            }

            str.append("\n");
        }

        return str.toString();
    }
}
