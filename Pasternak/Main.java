
public class Main {
    public Main() {
    }

    public static void main(String[] args) {
        int[][] first = new int[][]{{1, 2, 3}, {3, 2, 1}, {6, 5, 4}};
        int[][] second = new int[][]{{3, 5, 3}, {1, 5, 1}, {7, 4, 4}};
        Matrix m = new Matrix(first);
        System.out.println(m);
        Matrix m2 = new Matrix(second);
        System.out.println(m2);

        try {
            System.out.println(m.add(m2).add(m));
        } catch (Exception var6) {
            System.err.println(var6);
        }

    }
}
