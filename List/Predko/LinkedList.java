package org.example.Predko_List.Predko;

class LinkedList<T> {
    Node<T> head;

    LinkedList() {
        this.head = null;
    }

    public boolean isEmpty() {
        return head == null;
    }

    public void append(T data) {
        Node<T> newNode = new Node<>(data);
        if (head == null) {
            head = newNode;
            return;
        }
        Node<T> current = head;
        while (current.next != null) {
            current = current.next;
        }
        current.next = newNode;
    }

    public void appendFirst(T data) {
        Node<T> newNode = new Node<>(data);
        newNode.next = head;
        head = newNode;
    }

    public void appendAtIndex(int index, T data) {
        if (index < 0)
            throw new IndexOutOfBoundsException("Index out of bounds");

        if (index == 0) {
            appendFirst(data);
            return;
        }

        Node<T> newNode = new Node<>(data);
        Node<T> current = head;
        Node<T> prev = null;
        int count = 0;

        while (current != null && count != index) {
            prev = current;
            current = current.next;
            count++;
        }

        if (current == null && count != index)
            throw new IndexOutOfBoundsException("Index out of bounds");

        newNode.next = current;
        prev.next = newNode;
    }

    public void deleteLast() {
        if (head == null || head.next == null) {
            head = null;
            return;
        }

        Node<T> current = head;
        while (current.next.next != null) {
            current = current.next;
        }
        current.next = null;
    }

    public void deleteAtIndex(int index) {
        if (index < 0)
            return;

        if (index == 0) {
            head = head.next;
            return;
        }

        Node<T> current = head;
        Node<T> prev = null;
        int count = 0;

        while (current != null && count != index) {
            prev = current;
            current = current.next;
            count++;
        }

        if (current == null)
            return;

        prev.next = current.next;
    }

    public void replaceAtIndex(int index, T newValue) {
        if (index < 0)
            return;

        Node<T> current = head;
        int count = 0;

        while (current != null && count != index) {
            current = current.next;
            count++;
        }

        if (current != null) {
            current.data = newValue;
        }
    }

    public T get(int index) {
        if (index < 0 || head == null)
            throw new IndexOutOfBoundsException("Index out of bounds");

        Node<T> current = head;
        int count = 0;

        while (current != null && count != index) {
            current = current.next;
            count++;
        }

        if (current == null)
            throw new IndexOutOfBoundsException("Index out of bounds");

        return current.data;
    }

    public void printList() {
        Node<T> current = head;
        while (current != null) {
            System.out.print(current.data + " ");
            current = current.next;
        }
        System.out.println();
    }

    public void clear() {
        head = null;
    }
}
