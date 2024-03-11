namespace AddSubMatr;

public class Service
{
    public int[][] SumOfMatrix(int[][] FirstMatrix, int[][] SecondMatrix)
    {
        if (FirstMatrix.Length != SecondMatrix.Length || FirstMatrix[0].Length != SecondMatrix[0].Length || FirstMatrix.Length == 0 || FirstMatrix[0].Length == 0)
        {
            throw new ArgumentException("Invalid matrices for addition");
        }

        int rows = FirstMatrix.Length;
        int cols = FirstMatrix[0].Length;

        int[][] ResultOfSum = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            ResultOfSum[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                ResultOfSum[i][j] = FirstMatrix[i][j] + SecondMatrix[i][j];
            }
        }

        return ResultOfSum;
    }


    public int[][] SubtractionOfMatrix(int[][] FirstMatrix, int[][] SecondMatrix)
    {
        if (FirstMatrix.Length != SecondMatrix.Length || FirstMatrix[0].Length != SecondMatrix[0].Length || FirstMatrix.Length == 0 || FirstMatrix[0].Length == 0)
        {
            throw new ArgumentException("Invalid matrices for subtraction");
        }

        int rows = FirstMatrix.Length;
        int cols = FirstMatrix[0].Length;

        int[][] ResultOfSubtraction = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            ResultOfSubtraction[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                ResultOfSubtraction[i][j] = FirstMatrix[i][j] - SecondMatrix[i][j];
            }
        }

        return ResultOfSubtraction;
    }
    public int[][] MultiplyMatrices(int[][] FirstMatrix, int[][] SecondMatrix)
    {
        if (FirstMatrix[0].Length != SecondMatrix.Length || FirstMatrix.Length == 0 || FirstMatrix[0].Length == 0 || SecondMatrix.Length == 0 || SecondMatrix[0].Length == 0)
        {
            throw new ArgumentException("Invalid matrices for multiplication");
        }

        int rows = FirstMatrix.Length;
        int cols = SecondMatrix[0].Length;
        int commonLength = FirstMatrix[0].Length;

        int[][] ResultOfMultiplication = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            ResultOfMultiplication[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                ResultOfMultiplication[i][j] = 0;
                for (int k = 0; k < commonLength; k++)
                {
                    ResultOfMultiplication[i][j] += FirstMatrix[i][k] * SecondMatrix[k][j];
                }
            }
        }

        return ResultOfMultiplication;
    }

}