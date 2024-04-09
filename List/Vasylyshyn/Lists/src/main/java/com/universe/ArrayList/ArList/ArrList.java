package main.java.com.universe.ArrayList.ArList;

import main.java.com.universe.ArrayList.Interface.MyArrayList;

import java.util.Arrays;
import java.util.Collection;

public class ArrList<T> implements MyArrayList<T> {
    private static int Capacity = 3;
    private Object[] Array;
    private int Size;

    public ArrList(int size) {
        Capacity = size;
        this.Array = new Object[Capacity];
        this.Size = 0;
    }

    @Override
    public void Check() {
        if (Size == Array.length) {
            int newCapacity = (int) (Size * 1.5) + 1;
            Object[] newArray = new Object[newCapacity];
            System.arraycopy(Array, 0, newArray, 0, Size);
            Array = newArray;
        }
    }

    @Override
    public void Add(T element) {
        Check();
        Array[Size++] = element;
    }


    public void Add(T element, int index) {
        Check();
        System.arraycopy(Array, index, Array, index + 1, Size - index);
        Array[index] = element;
        Size++;
    }


    @Override
    public T Remove(int index) {
        if (index < 0 || index >= Size)
            throw new IndexOutOfBoundsException("Мимо немає такого індексу спробуйте ще раз :)");
        T removedElement = (T) Array[index];
        System.arraycopy(Array, index + 1, Array, index, Size - index - 1);
        Array[--Size] = null;
        return removedElement;
    }

    @Override
    public void Clear() {
        for (int i = 0; i < Size; i++)
            Array[i] = null;
        Size = 0;
    }

    @Override
    public void Set(int index, T value) {
        Check();
        System.arraycopy(Array, index, Array, index + 1, Size - index);
        Array[index] = value;
        Size++;
    }

    @Override
    public int Size() {
        return Size;
    }

    @Override
    public Object Get(int i) {
        return Array[i];
    }

    @Override
    public void AddFirst(T value) {
        Set(0, value);
    }

    @Override
    public void AddLast(T value) {
        Set(Size, value);
    }

    @Override
    public boolean AddAll(Collection<? extends T> c) {
        Object[] a = c.toArray();
        if (a.length == 0)
            return false;
        Object[] elementData;
        final int s;
        if (a.length > (elementData = this.Array).length - (s = Size))
            elementData = AddSpace();
        System.arraycopy(a, 0, elementData, s, a.length);
        Size = s + a.length;
        return true;
    }

    private Object[] AddSpace() {
        int newCapacity = Array.length + (Array.length / 2);
        return Array = Arrays.copyOf(Array, newCapacity);
    }

    @Override
    public String toString() {
        return Arrays.toString(Array);
    }
}
