using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class ArrayList
    {
        private object[] array;
        private int size;
        private int capacity;

        public ArrayList()
        {
            capacity = 10;
            array = new object[capacity];
            size = 0;
        }

        private void Resize()
        {
            capacity = (int)(1.5 * capacity) + 1;
            object[] newArray = new object[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }

        public void Add(object item)
        {
            if (size == capacity)
            {
                Resize();
            }
            array[size] = item;
            size++;
        }

        public void Remove(object item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;
        }

        public void Insert(int index, object item)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException();
            }
            if (size == capacity)
            {
                Resize();
            }
            for (int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = item;
            size++;
        }

        public void Clear()
        {
            array = new object[capacity];
            size = 0;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                array[index] = value;
            }
        }

        public int Count
        {
            get { return size; }
        }
    }
}
