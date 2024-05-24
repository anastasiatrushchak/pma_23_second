package main.java.com.universe.ArrayList.Interface;

import java.util.Collection;

public interface MyArrayList<T> {
    void Add(T value);

    void Add(T value, int index);

    Object Get(int i);

    void Set(int index, T value);

    T Remove(int index);

    void Clear();

    int Size();

    void AddFirst(T value);

    void AddLast(T value);

    void Check();

    boolean AddAll(Collection<? extends T> c);
}
