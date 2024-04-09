package lnu.com.list.MyList.myListImpl;

public class MyNode<T> {
    private MyNode prev;
    private T data;
    private MyNode next;

    public MyNode(T data){
        this.prev = null;
        this.data = data;
        this.next = null;
    }

    @Override
    public String toString() {
        return data.toString();
    }

    public MyNode(T data, MyNode prev){
        this.data = data;
        this.prev = prev;
    }

    public MyNode getPrev() {
        return prev;
    }

    public void setPrev(MyNode prev) {
        this.prev = prev;
    }

    public T getData() {
        return data;
    }

    public void setData(T data) {
        this.data = data;
    }

    public MyNode getNext() {
        return next;
    }

    public void setNext(MyNode next) {
        this.next = next;
    }
}
