using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Service
    {
        public static Matrix ReadMatrixFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string[] dimensions = reader.ReadLine().Split(' ');
                int rows = int.Parse(dimensions[0]);
                int columns = int.Parse(dimensions[1]);

                Matrix matrix = new Matrix(rows, columns);

                for (int i = 0; i < rows; i++)
                {
                    string[] rowValues = reader.ReadLine().Split(' ');
                    for (int j = 0; j < columns; j++)
                    {
                        try
                        {
                            matrix[i, j] = int.Parse(rowValues[j]);
                        }catch (FormatException) {
                            throw new ArgumentException("Invalid input format in file");
                        }
                    }
                }

                return matrix;
            }
        }
    }
}
