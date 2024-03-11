using System;
using System.IO;
using System.Collections.Generic;

namespace Matrix
{
    internal class MatrixService
    {
        public static CustomMatrix LoadMatrixFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                List<string> lines = new List<string>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                int rows = lines.Count;
                int columns = lines[0].Split(' ').Length;

                CustomMatrix matrix = new CustomMatrix(rows, columns);

                for (int i = 0; i < rows; i++)
                {
                    string[] rowValues = lines[i].Split(' ');

                    if (rowValues.Length != columns)
                    {
                        throw new ArgumentException("Invalid number of values in the matrix file");
                    }

                    for (int j = 0; j < columns; j++)
                    {
                        if (!int.TryParse(rowValues[j], out int value))
                        {
                            throw new ArgumentException("Invalid input format in file");
                        }

                        matrix[i, j] = value;
                    }
                }

                return matrix;
            }
        }
    }
}
