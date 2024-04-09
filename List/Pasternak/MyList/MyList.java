package lnu.com.list.MyList;


import java.util.stream.Stream;

public interface MyList<T>{
    boolean add(T data);
    boolean add(T data, int index);
    boolean remove(int index);
    T get(int index);
    int getSize();
    void deleteAll();
    String toString();
    Stream<T> stream();
}
