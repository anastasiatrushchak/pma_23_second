using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    public class Vector(double[] vector) 
    {
        private readonly double[] _vector = vector;

        private double this[int x]
        {
            get { return _vector[x]; }
        }

        public int Length { get { return _vector.Length; } }

        public static bool EqualSize(Vector This, Vector Other)
        {
            if (This.Length == Other.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Vector operator +(Vector This, Vector Other)
        {
            if (!EqualSize(This, Other))
            {
                throw new NotEqualSizesException();
            }
            double[] result = new double[This.Length];
            for (int x = 0; x < This.Length; x++)
            {
                result[x] = This[x] + Other[x];
            }
            return new Vector(result);
        }

        public static Vector operator -(Vector This, Vector Other)
        {
            if (!EqualSize(This, Other))
            {
                throw new NotEqualSizesException();
            }
            double[] result = new double[This.Length];
            for (int x = 0; x < This.Length; x++)
            {
                    result[x] = This[x] - Other[x];
            }
            return new Vector(result);
        }

        public static Vector operator *(Vector This, double Number) { return null; }

        public static Vector operator *(double Number, Vector This) { return null; }

        public static Vector operator /(Vector This, double Number) { return null; }

        public override string ToString()
        {
            string strVector = "";
            for (int x = 0; x < Length; x++)
            {
                strVector += _vector[x].ToString() + '\t';
            }
            return strVector;
        }
    }
}
