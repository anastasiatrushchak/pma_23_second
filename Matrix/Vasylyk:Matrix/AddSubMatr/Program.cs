namespace AddSubMatr
{
    public class MainClass
    {
        public static void Main()
        {
            int[][] matrix1 = ReadMatrixFromFile("/Users/nasta/RiderProjects/AddSubMatr/AddSubMatr/input1.txt");
            int[][] matrix2 = ReadMatrixFromFile("/Users/nasta/RiderProjects/AddSubMatr/AddSubMatr/input2.txt");

            Service service = new Service();
            if (matrix1 != null && matrix2 != null)
            {
                try
                {
                    int[][] resultMatrixSubtraction = service.SubtractionOfMatrix(matrix1, matrix2);
                    int[][] resultMatrixSum = service.SumOfMatrix(matrix1, matrix2);
                    int[][] resultMatrixMultiplication = service.MultiplyMatrices(matrix1, matrix2);

                    Console.WriteLine("Matrix 1:");
                    PrintMatrix(matrix1);

                    Console.WriteLine("\nMatrix 2:");
                    PrintMatrix(matrix2);

                    Console.WriteLine("\nResult of Subtraction:");
                    PrintMatrix(resultMatrixSubtraction);

                    Console.WriteLine("\nResult of Sum:");
                    PrintMatrix(resultMatrixSum);

                    Console.WriteLine("\nResult of Multiplication:");
                    PrintMatrix(resultMatrixMultiplication);

                    string fileOutput = "/Users/nasta/RiderProjects/AddSubMatr/AddSubMatr/output.txt";
                    WriteResultsToFile(fileOutput, "Matrix 1:", matrix1);
                    WriteResultsToFile(fileOutput, "Matrix 2:", matrix2);
                    WriteResultsToFile(fileOutput, "Result of Subtraction:", resultMatrixSubtraction);
                    WriteResultsToFile(fileOutput, "Result of Sum:", resultMatrixSum);
                    WriteResultsToFile(fileOutput, "Result of Multiplication:", resultMatrixMultiplication);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Error reading matrices from file.");
            }
        }


        static int[][] ReadMatrixFromFile(string filePath)
        {
            try
            {
                int rows = 0;
                int cols = 0;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        rows++;
                        string[] elements = line.Trim().Split(' ');
                        cols = Math.Max(cols, elements.Length);
                    }
                }

                int[][] matrix = new int[rows][];

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int row = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] elements = line.Trim().Split(' ');

                        if (elements.Length != cols)
                        {
                            throw new InvalidOperationException($" Not the same size of matrix. Expected {cols}, found {elements.Length} at row {row}");
                        }

                        matrix[row] = new int[cols];
                        for (int col = 0; col < elements.Length; col++)
                        {
                            if (int.TryParse(elements[col], out int value))
                            {
                                matrix[row][col] = value;
                            }
                            else
                            {
                                Console.WriteLine($"Error parsing element at row {row}, col {col}");
                            }
                        }

                        row++;
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }

        static void WriteResultsToFile(string filePath, string message, int[][] matrix)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(message);
                    foreach (var row in matrix)
                    {
                        foreach (var element in row)
                        {
                            writer.Write(element + " ");
                        }
                        writer.WriteLine();
                    }
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
        public static void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
