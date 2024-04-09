package lnu.com.list.MyList.myListImpl;

import lnu.com.list.MyList.MyList;
import lnu.com.list.exception.IndexException;

import java.util.Arrays;
import java.util.Objects;
import java.util.stream.Stream;

public class MyArrayList<T> implements MyList<T> {
    private static final int DEFAULT_CAPACITY = 10;
    private int size = 0;
    private int capacity = DEFAULT_CAPACITY;
    private Object[] array = new Object[DEFAULT_CAPACITY];

    public MyArrayList(){
    }
    public MyArrayList(int capacity){
        this.capacity = capacity;
        array = new Object[capacity];
    }
    public MyArrayList(T... data){
        Arrays.stream(data).filter(Objects::nonNull).forEach(this::add);
    }
    public MyArrayList(MyList<T> list){
        list.stream().forEach(this::add);
    }
    @Override
    public boolean add(T data){
        checkCapacity();
        array[size] = data;
        size++;
        return true;
    }

    @Override
    public boolean add(T newElement ,int indexAdd){
        if (indexAdd < 0 || indexAdd > size){
            throw new IndexException("Index is "+ indexAdd +" out of bounds");
        }
        checkCapacity();
        System.arraycopy(array, indexAdd, array, indexAdd + 1, size - indexAdd);
        array[indexAdd] = newElement;
        size++;
        return true;
    }
    @Override
    public boolean remove(int indexRemove){
        if (indexRemove < 0 || indexRemove >= size){
            throw new IndexException("Index is "+ indexRemove +" out of bounds");
        }
        System.arraycopy(array, indexRemove + 1, array, indexRemove, size - indexRemove - 1);
        size--;
        return true;
    }
    @Override
    public T get(int index){
        if (index < 0 || index >= size){
            throw new IndexException("Index is "+ index +" out of bounds");
        }
        return (T) array[index];
    }
    @Override
    public int getSize() {
        return size;
    }
    @Override
    public void deleteAll(){
        size = 0;
        capacity = DEFAULT_CAPACITY;
        array = new Object[DEFAULT_CAPACITY];
    }
    @Override
    public String toString() {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.append("[");
        for (int i = 0; i < size; i++){
            stringBuilder.append(array[i]);
            if (i < size - 1){
                stringBuilder.append(", ");
            }
        }
        stringBuilder.append("]");
        return stringBuilder.toString();
    }

    private void checkCapacity(){
        if (size == capacity){
            capacity *= 2;
            Object[] newArray = new Object[capacity];
            System.arraycopy(array, 0, newArray, 0, size);
            array = newArray;
        }
    }

    @Override
    public Stream<T> stream() {
        return Stream.of((T[]) array).limit(getSize());
    }

    public int getCapacity() {
        return capacity;
    }
}
