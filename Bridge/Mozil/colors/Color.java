package colors;

public abstract class Color {
    private String color;
    public Color(String color) {
        this.color = color;
    }

    @Override
    public String toString() {
        return color;
    }
}
