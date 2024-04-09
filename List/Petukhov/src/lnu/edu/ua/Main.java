package lnu.edu.ua;
public class Main {

    public static void main(String[] args) {
//        // Linked List
//        System.out.println("LinkedList:");
//
//        List<Integer> linkedList = new LinkedList<>();
//
//        System.out.println(linkedList + ", size: " + linkedList.size());
//
//        linkedList.add(1);
//        linkedList.add(2);
//        linkedList.add(3);
//        linkedList.add(4);
//        linkedList.add(5);
//
//        System.out.println(linkedList + ", size: " + linkedList.size());
//
//        System.out.println(linkedList.get(2));
//        linkedList.remove(2);
//        System.out.println(linkedList.get(2));
//
//        System.out.println(linkedList + ", size: " + linkedList.size());
//
//        // Array List
//        System.out.println("\nArrayList:");
//
//        List<Integer> arrayList = new ArrayList<>();
//
//        System.out.println(arrayList + ", size: " + arrayList.size());
//
//        arrayList.add(1);
//        arrayList.add(2);
//        arrayList.add(3);
//        arrayList.add(4);
//        arrayList.add(5);
//
//        System.out.println(arrayList + ", size: " + arrayList.size());
//
//        System.out.println(arrayList.get(2));
//        arrayList.remove(2);
//        System.out.println(arrayList.get(2));
//
//        System.out.println(arrayList + ", size: " + arrayList.size());

//        List<Integer> list = new ArrayList<>(8);
//
//        for (int i = 0; i < 8; i++) {
//            list.add(i);
//        }
//
//        list.remove(6);
//
//        list.add(111);
//        list.add(222);
//
//        list.remove(3);
//        list.remove(4);
//
//        System.out.println();


        List<Integer> list = new LinkedList<>();

        list.add(1);
        list.add(2);
        list.add(3);
        list.add(4);

        list.add(5, 3);

        list.remove(1);

        list.add(6, 4);

        System.out.println();
    }
}