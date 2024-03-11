using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix;


class Matrix
{
    private int[,] data;
    private int rows;
    private int columns;
    public Matrix() { } 
    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        data = new int[rows, columns];
    }

    public int Rows { get { return rows; } }
    public int Columns { get { return columns; } }

    public int this[int i, int j]
    {
        get { return data[i, j]; }
        set { data[i, j] = value; }
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        Matrix result = new Matrix(m1.Rows, m1.Columns);

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }

        return result;
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        Matrix result = new Matrix(m1.Rows, m1.Columns);

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Columns; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.Columns != m2.Rows)
        {
            throw new ArgumentException("Number of columns in first matrix must be equal to the number of rows in the second matrix");
        }

        Matrix result = new Matrix(m1.Rows, m2.Columns);

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

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result += data[i, j] + " ";
            }
            result += "\n";
        }

        return result;
    }
}