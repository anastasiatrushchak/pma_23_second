using System;
using System.Linq;

namespace ArrayList
{
    public class ArrayList<T>
    {
        private T[] data;
        private int capacity;
        private int count;

        public ArrayList()
        {
            this.data = new T[1];
            this.capacity = 1;
            this.count = 0;
        }

        public ArrayList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Введіть невід'ємний розмір!");
            }
            this.data = new T[capacity];
            this.capacity = capacity;
            this.count = 0;
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get { return this.data[index]; }
            set { this.data[index] = value; }
        }

        public void RaiseSize()
        {
            this.capacity = (int)(1.5 * this.capacity) + 1;
            Array.Resize(ref this.data, this.capacity);
        }

        public void Append(T item)
        {
            if (this.count == this.capacity)
            {
                this.RaiseSize();
            }
            this.data[this.count] = item;
            this.count++;
        }

        public void Insert(int index, T item)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Введіть невід'ємний індекс!");
            }
            else if (index > this.count)
            {
                while (this.capacity < index)
                {
                    this.RaiseSize();
                }
            }
            if (this.count == this.capacity)
            {
                this.RaiseSize();
            }
            Array.Copy(this.data, index, this.data, index + 1, this.count - index);
            this.data[index] = item;
            this.count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("Неправильний індекс!");
            }
            else
            {
                Array.Copy(this.data, index + 1, this.data, index, this.count - index - 1);
                this.count--;
            }
        }

        public void Clear()
        {
            this.data = new T[1];
            this.capacity = 1;
            this.count = 0;
        }

        public override string ToString()
        {
            return $"ArrayList: {string.Join(", ", this.data.Take(this.count))}, Size: {this.count}, Capacity: {this.capacity}";
        }
    }
}
