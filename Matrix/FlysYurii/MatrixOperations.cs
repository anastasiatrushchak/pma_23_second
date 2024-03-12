

namespace Add_Substract_Matrix_{
    static class MatrixOperations
    {
        public static void ReadMatrix(string filename, out int[,] matrix)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                matrix = new int[lines.Length, lines[0].Split(' ').Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] numbers = lines[i].Split(' ');
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
                matrix = null;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid format: " + ex.Message);
                matrix = null;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                matrix = null;
            }
        }
        public static void PrintMatrix(int[,] matrix)
        {
            try
            {
                if (matrix == null)
                {
                    throw new NullReferenceException("Matrix cannot be null.");
                }


                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Argument is null: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return;
            }
        }
        public static void AddMatrix(int[,] matrix1, int[,] matrix2, out int[,] result)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new ArgumentException("Матриці повинні бути однакового розміру для додавання.");
            }
            result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
        }
        public static void SubstractMatrix(int[,] matrix1, int[,] matrix2, out int[,] result)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new ArgumentException("Матриці повинні бути однакового розміру для додавання.");
            }
            result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
        }
        public static void MultiplyMatrix(int[,] matrix1, int[,] matrix2, out int[,] result)
        {
            try
            {
                result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix1.GetLength(1); k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range: " + ex.Message);
                result = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                result = null;
            }
        }
        
    }
}
