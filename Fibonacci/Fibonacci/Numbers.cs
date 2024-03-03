using System.Collections.Generic;
namespace fibonacci
{
    public class Fibonacci
    {
        private List<double> array = new List<double>();
        private int steps;
        private Fibonacci()
        {

        }
        public List<double> Array { get => array; private set => array = value; }
        public int Steps { get => steps; set => steps = value; }
        public static Fibonacci Generate(List<double> array, int steps)
        {
          
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            return new Fibonacci { array = array, steps = steps };
        }

        public override string ToString()
        {
            return $"Steps:{steps}, Fibonacci: {string.Join(",", array)}";

        }
    }
}