
namespace Add_Substract_Matrix_
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            int[,] matrix1, matrix2, result;
            MatrixOperations.ReadMatrix("matrix1.txt", out matrix1);
            MatrixOperations.ReadMatrix("matrix2.txt", out matrix2);
            Console.WriteLine("Matrix 1:");
            MatrixOperations.PrintMatrix(matrix1);
            Console.WriteLine("Matrix 2:");
            MatrixOperations.PrintMatrix(matrix2);
            MatrixOperations.AddMatrix(matrix1, matrix2, out result);
            Console.WriteLine("Addition:");
            MatrixOperations.PrintMatrix(result);
            MatrixOperations.SubstractMatrix(matrix1, matrix2, out result);
            Console.WriteLine("Substraction:");
            MatrixOperations.PrintMatrix(result);
            MatrixOperations.MultiplyMatrix(matrix1, matrix2, out result);
            Console.WriteLine("Multiplication:");
            MatrixOperations.PrintMatrix(result);
        }
    }
}
