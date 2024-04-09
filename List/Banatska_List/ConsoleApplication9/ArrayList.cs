using System;

namespace ConsoleApplication9
{
    public class ArrayList<T>
    {
        private T[] array;
        private int count;
        
        public ArrayList(int initialCapacity)
        {
            if (initialCapacity < 0)
                throw new ArgumentException("Initial capacity cannot be negative.");

            array = new T[initialCapacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                int newCapacity = (int)(array.Length * 1.5) + 1;
                T[] newArray = new T[newCapacity];
                Array.Copy(array, newArray, count);
                array = newArray;
            }

            array[count] = item;
            count++;
        }

        public void Pop()
        {
            if (count > 0)
            {
                count--;
                array[count] = default(T);
            }
            else
            {
                throw new InvalidOperationException("Cannot pop from an empty ArrayList.");
            }
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[count - 1] = default(T);
            count--;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (count == array.Length)
            {
                int newCapacity = (int)(array.Length * 1.5) + 1;
                T[] newArray = new T[newCapacity];
                Array.Copy(array, newArray, count);
                array = newArray;
            }

            for (int i = count; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = item;
            count++;
        }

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return array.Length; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                array[index] = value;
            }
        }

        public void Print()
        {
            Console.Write("ArrayList: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
