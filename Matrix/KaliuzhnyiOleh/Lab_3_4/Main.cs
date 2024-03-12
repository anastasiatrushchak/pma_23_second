using System.Numerics;
using System.Runtime.Intrinsics;
using System.Xml.Linq;

namespace Lab_3_4
{
    public class Lab_3_4
    {
        public const string matrixOne = "E:/Навчання_4_семестр/Програмування/Лабораторні/Lab_3_4/Lab_3_4/matrixOne.txt";
        public const string matrixTwo = "E:/Навчання_4_семестр/Програмування/Лабораторні/Lab_3_4/Lab_3_4/matrixTwo.txt";
        public const string resultPath = "E:/Навчання_4_семестр/Програмування/Лабораторні/Lab_3_4/Lab_3_4/result.txt";
        public static void Main()
        {
            try
            {
                double[,] matrix_one = { {1, 2, 3 },
                                   {1, 2, 3 },
                                   {1, 2, 3 } };
                double[,] matrix_two = { {3, 4, 5 },
                                  {3, 3, 3 },
                                  {6, 9, 6 } };
                double[,] matrix_tree = { {1, 2, 3 },
                                  {1, 2, 3 },
                                  {1, 2, 3 } };

                Matrix m_one = ReadMatrix(matrixOne);
                Matrix m_two = ReadMatrix(matrixTwo);
                Matrix m_three = new Matrix(matrix_one);
                Matrix m_four = new Matrix(matrix_two);
                Console.WriteLine(m_one);
                Console.WriteLine(m_two);
                Console.WriteLine(m_one+m_two);
                WriteMatrix(resultPath, m_one + m_two);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static Matrix ReadMatrix(string filename)
        {
            List<List<double>> listMatrix = new List<List<double>>();

            try
            {
                foreach (string line in File.ReadAllLines(filename))
                {
                    List<double> vector = new List<double>();
                    foreach (string element in line.Split())
                    {
                        if (double.TryParse(element, out double number))
                        {
                            vector.Add(number);
                        }
                        else
                        {
                            throw new FormatException($"Wrong element input.");
                        }
                    }
                    listMatrix.Add(vector);
                }

                int rows = listMatrix.Count;
                int cols = listMatrix.Max(v => v.Count);

                double[,] matrix = new double[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < listMatrix[i].Count; j++)
                    {
                        matrix[i, j] = listMatrix[i][j];
                    }
                }

                return new Matrix(matrix);
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error reading matrix from {filename}: {err.Message}");
                return null;
            }
        }
        public static void WriteMatrix(string filename, Matrix matrix)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filename))
                {
                    file.WriteLine(matrix.ToString());
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error writing matrix to {filename}: {err.Message}");
            }
        }
    }
}