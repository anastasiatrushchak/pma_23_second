using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class CustomMatrix
    {
        private int[,] customData;
        private int customRows;
        private int customColumns;

        public CustomMatrix() { }
        public CustomMatrix(int rows, int columns)
        {
            this.customRows = rows;
            this.customColumns = columns;
            customData = new int[rows, columns];
        }

        public int Rows { get { return customRows; } }
        public int Columns { get { return customColumns; } }

        public int this[int i, int j]
        {
            get { return customData[i, j]; }
            set { customData[i, j] = value; }
        }

        public static CustomMatrix operator +(CustomMatrix m1, CustomMatrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                throw new ArgumentException("Matrices must have the same size");
            }

            CustomMatrix result = new CustomMatrix(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }

        public static CustomMatrix operator -(CustomMatrix m1, CustomMatrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                throw new ArgumentException("Matrices must have the same size");
            }

            CustomMatrix result = new CustomMatrix(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static CustomMatrix operator *(CustomMatrix m1, CustomMatrix m2)
        {
            if (m1.Columns != m2.Rows)
            {
                throw new ArgumentException("Number of columns in first matrix must be equal to the number of rows in the second matrix");
            }

            CustomMatrix result = new CustomMatrix(m1.Rows, m2.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    for (int k = 0; k < m1.Columns; k++)
                    {
                        result[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < customRows; i++)
            {
                for (int j = 0; j < customColumns; j++)
                {
                    result += customData[i, j] + " ";
                }
                result += "\n";
            }

            return result;
        }
    }
}
