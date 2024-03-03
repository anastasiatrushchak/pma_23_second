import java.util.List;

class Sequence {
    static int MaxValue;
    static List<Integer> Fibonacci;

    protected Sequence() {
    }

    public int getMaxValue() {
        return MaxValue;
    }

    public void setMaxValue(int maxValue) {
        MaxValue = maxValue;
    }

    public List<Integer> getFibonacci() {
        return Fibonacci;
    }

    public void setFibonacci(List<Integer> fibonacci) {
        Fibonacci = fibonacci;
    }
}