using System;
using System.Linq;

namespace ArrayList
{
    public class Array<T>
    {
        private int size;
        private T[] list; 
        private int capacity;

        public Array(int _capacity)
        {
            list = new T[_capacity]; 
            this.capacity = _capacity;
        }

        public void Push(T elem)
        {
            if (size == capacity)
            {
                int new_capacity = (int)(1.5 * capacity + 1);
                T[] new_list = new T[new_capacity];
                Array.Copy(list, new_list, capacity);
                list = new_list;
                capacity = new_capacity; 
            }
            list[size++] = elem;
        }

        public void Pop()
        {
            if (size == 0)
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                size--;
            }
        }

        public void PopByIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Index error");
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                list[i] = list[i + 1];
            }

            size--;
        }

        public override string ToString()
        {
            return string.Join(", ", list.Take(size));
        }
    }
}
