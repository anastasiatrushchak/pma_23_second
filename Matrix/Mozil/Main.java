public class Main {
    public static void main(String[] args) {
        Matrix a = new Matrix(2, 2);
        a.matrixConsoleInput();
        System.out.print(a);
        Matrix b = new Matrix(2, 2);
        b.matrixConsoleInput();
        System.out.println(b);
        a.plus(b);
        System.out.println("Result:\n" + a);
        b.minus(a);
        System.out.println("Result:\n" + b);

        Matrix m = Util.multiply(a, b);
        System.out.println("Multiply:\n" + m);
    }
}