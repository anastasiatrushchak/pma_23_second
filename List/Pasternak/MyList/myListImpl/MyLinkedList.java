package lnu.com.list.MyList.myListImpl;

import lnu.com.list.MyList.MyList;
import lnu.com.list.exception.IndexException;

import java.util.Arrays;
import java.util.List;
import java.util.Objects;
import java.util.stream.Stream;

public class MyLinkedList<T> implements MyList<T> {
    private MyNode start;
    private MyNode finish;
    private int size;

    public MyLinkedList(){
        size = 0;
    }
    public MyLinkedList(T... data){
        Arrays.stream(data).filter(Objects::nonNull).forEach(this::add);
    }
    public MyLinkedList(List<T> list){
        list.stream().forEach(this::add);
    }
    @Override
    public int getSize() {
        return size;
    }
    @Override
    public boolean add(T data){
        MyNode<T> newNode = new MyNode<>(data);
        if (size == 0){
            this.start = newNode;
            this.finish = start;
            size++;
            return true;
        } else {
            finish.setNext(newNode);
            newNode.setPrev(finish);
            finish = newNode;
            size++;
            return true;
        }
    }
    @Override
    public boolean add(T newElement ,int indexAdd){
        MyNode<T> newNode = new MyNode<>(newElement);

        if (indexAdd == size){
            return add(newElement);
        }
        if (indexAdd == 0){
            newNode.setNext(start);
            start.setPrev(newNode);
            start = newNode;
            size++;
            return true;
        }
        MyNode<T> element = getNodeByIndex(indexAdd);
        if (element != null){
            MyNode<T> prevElement = element.getPrev();
            MyNode<T> nextElement = element;

            prevElement.setNext(newNode);
            newNode.setPrev(prevElement);

            newNode.setNext(nextElement);
            nextElement.setPrev(newNode);
            size++;
            return true;
        }
        throw new IndexException("Index is "+ indexAdd +" out of bounds");
    }
    @Override
    public boolean remove(int indexRemove){
        if (indexRemove == size-1){
            MyNode<T> prev =  finish.getPrev();
            prev.setNext(null);
            finish = prev;
            size--;
            return true;
        }
        if (indexRemove == 0){
            MyNode<T> secondNode = start.getNext();
            secondNode.setPrev(null);
            start = secondNode;
            size--;
            return true;
        }
        MyNode<T> element = getNodeByIndex(indexRemove);
        if (element != null){
            element.getPrev().setNext(element.getNext());
            element.getNext().setPrev(element.getPrev());
            size--;
            return true;
        }
        throw new IndexException("Index is "+ indexRemove +" out of bounds");
    }
    @Override

    public T get(int getIndex) {
        return getNodeByIndex(getIndex).getData();
    }
    @Override

    public void deleteAll(){
        start = null;
        finish = null;
        size = 0;
    }
    @Override
    public String toString() {
        MyNode element = start;
        String result = "[";
        while (element !=null){
            result += element + " ";
            element = element.getNext();
        }
        return result.trim() + "]";
    }

    private MyNode<T> getNodeByIndex(int getIndex){
        MyNode<T> element = start;
        int index = 0;
        while(element != null){
            if (index == getIndex){
                return element;
            }
            element = element.getNext();
            index++;
        }
        return null;
    }

    @Override
    public Stream<T> stream() {
        return (Stream<T>) Stream.iterate(start, Objects::nonNull, MyNode::getNext)
                .map(MyNode::getData);
    }
}
