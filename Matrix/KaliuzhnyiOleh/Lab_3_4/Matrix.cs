using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    public class Matrix(double[,] matrix)
    {
        private double[,] _matrix = matrix;

        private double this[int x, int y]
        {
            get { return _matrix[x, y]; }
            set { _matrix[x, y] = value; }
        }

        public int Rows => _matrix.GetLength(0);
        public int Cols => _matrix.GetLength(1);

        public static bool EqualSize(Matrix This, Matrix Other)
        {
            if(This.Cols == Other.Cols && This.Rows == Other.Rows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Matrix operator + (Matrix This, Matrix Other)
        {
            if(!EqualSize(This, Other))
            {
                throw new NotEqualSizesException();
            }
            double[,] result = new double[This.Rows, This.Cols]; 
            for (int x = 0; x < This.Rows; x++)
            {
                for(int y = 0;  y < This.Cols; y++)
                {
                    result[x, y] = This[x, y]+Other[x, y];
                }
            }
            return new Matrix(result);
        }

        public static Matrix operator - (Matrix This, Matrix Other)
        {
            if (!EqualSize(This, Other))
            {
                throw new NotEqualSizesException();
            }
            double[,] result = new double[This.Rows, This.Cols];
            for (int x = 0; x < This.Rows; x++)
            {
                for (int y = 0; y < This.Cols; y++)
                {
                    result[x, y] = This[x, y] - Other[x, y];
                }
            }
            return new Matrix(result);
        }

        public static Matrix operator *(Matrix This, Matrix Other)
        {
            if (This.Cols != Other.Rows)
            {
                throw new ArgumentException("Invalid matrix dimensions for multiplication");
            }

            Matrix result = new Matrix(new double[This.Rows, Other.Cols]);

            for (int i = 0; i < This.Rows; i++)
            {
                for (int j = 0; j < Other.Cols; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < This.Cols; k++)
                    {
                        sum += This[i, k] * Other[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        public override string ToString()
        {
            string strMatrix = "";
            for (int x = 0; x< Rows; x++)
            {
                for(int y = 0; y< Cols; y++)
                {
                    strMatrix += _matrix[x, y].ToString() + '\t';
                }
                strMatrix += "\n";
            }
            return strMatrix;
        }
    }
}
