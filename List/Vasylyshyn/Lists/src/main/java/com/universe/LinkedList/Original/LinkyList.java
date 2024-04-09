package main.java.com.universe.LinkedList.Original;


import java.util.List;
import java.util.NoSuchElementException;

public class LinkyList<T> {
    public int Size = 0;
    public Noda<T> First;
    public Noda<T> Last;

    public LinkyList() {
    }

    public LinkyList(int size) {
        Size = size;
    }

    public void AddFirst(T Element) {
        final Noda<T> FirstElement = First;
        final Noda<T> NewFirstNode = new Noda<>(null, Element, FirstElement);
        First = NewFirstNode;
        if (FirstElement == null) {
            Last = NewFirstNode;
        } else FirstElement.Prev = NewFirstNode;
        Size++;
    }

    public void AddLast(T Element) {
        final Noda<T> LastElement = Last;
        final Noda<T> NewLastElement = new Noda<>(LastElement, Element, null);
        Last = NewLastElement;
        if (LastElement == null) {
            First = NewLastElement;
        } else {
            LastElement.Next = NewLastElement;
        }
        Size++;
    }

    public boolean Add(T Element) {
        AddLast(Element);
        return true;
    }

    public T GetFirst() {
        if (First == null) {
            throw new NoSuchElementException("Походу пустий чи що");
        }
        return First.Item;
    }

    public T GetLast() {
        if (Last == null) {
            throw new NoSuchElementException("Пусто напевно");
        }
        return Last.Item;
    }

    public void GetAll() {
        if (Last == null && First == null) {
            throw new NoSuchElementException("Пусто");
        }
        System.out.print("[");
        for (int i = 0; i < Size - 1; i++) {
            System.out.print(GetId(i).Item + ", ");
        }
        System.out.print(GetLast());
        System.out.println("]");
    }


    public Noda<T> GetId(int Id) {
        if (Id < 0 || Id > Size - 1) {
            throw new IndexOutOfBoundsException("Шось не те нема тагого індексу");
        }
        if (Id <= (Size / 2)) {
            Noda<T> FirstElement = First;
            for (int i = 0; i < Id; i++) {
                FirstElement = FirstElement.Next;
            }
            return FirstElement;

        } else {
            Noda<T> LastElement = Last;
            for (int i = Size - 1; i > Id; i--) {
                LastElement = LastElement.Prev;
            }
            return LastElement;
        }
    }

    public void Remove(int Id) {
        if (Id < 0 && Id > Size - 1) {
            throw new IndexOutOfBoundsException("Index " + Id + "Dos not exsist");
        }
        if (Id == 0) {
            RemoveFirst();
        } else if (Id == Size - 1) {
            RemoveLast();

        } else {
            Noda<T> ForDelete = GetId(Id);
            ForDelete.Prev.Next = ForDelete.Next;
            ForDelete.Next.Prev = ForDelete.Prev;
            Size--;
        }
    }

    public void RemoveFirst() {
        First = First.Next;
        Size--;
    }

    public void RemoveLast() {
        Last = Last.Prev;
        Size--;
    }

    public void RemoveAll() {
        First = null;
        Last = null;
        Size = 0;
    }

    public int GetSize() {
        return Size;
    }

    @Override
    public String toString() {
        return STR."LinkyList{Size=\{Size}, First=\{First}, Last=\{Last}}";
    }

    private static class Noda<T> {
        T Item;
        Noda<T> Next;
        Noda<T> Prev;

        Noda(Noda<T> prev, T Element, Noda<T> next) {
            this.Item = Element;
            this.Next = next;
            this.Prev = prev;
        }

        @Override
        public String toString() {
            return STR."Noda{Item=\{Item}, Next=\{Next != null ? Next.Item : "null"}, Prev=\{Prev != null ? Prev.Item : "null"}}";
        }
    }

}


