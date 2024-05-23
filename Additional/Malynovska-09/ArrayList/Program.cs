using System;
using System.Text;


namespace ArrayList
{
    public class ArrayList<T>
    {
        private T[] array;
        private int capacity;
        private int size;

        public ArrayList(T[] array)
        {
            this.capacity = array.Length;
            this.size = array.Length;
            this.array = array;
            Resize();
        }
        public ArrayList(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            this.array = new T[capacity];
        }

        private void Resize()
        {
            capacity = (int)(1.5 * capacity) + 1;
            T[] newArray = new T[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }
        public void WriteCapacity()
        {
            Console.WriteLine("Capacity" +  capacity);
        }

        public void Add(T element)
        {
            if (size == capacity)
            {
                Resize();
            }
            array[size] = element;
            size++;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Invalid index. Deletion failed.");
            }
            else
            {
                for (int i = index; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[size - 1] = default(T);
                size--;
            }
        }

        public void PutByIndex(int index, T element)
        {
            if (size == capacity)
            {
                Resize();
            }
            for (int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = element;
            size++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ArrayList: [");
            for (int i = 0; i < size; i++)
            {
                sb.Append(array[i]);
                if (i < size - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }
        public void Write()
        {
            Console.WriteLine("ArrayList: " + ToString());
        }
    }
}