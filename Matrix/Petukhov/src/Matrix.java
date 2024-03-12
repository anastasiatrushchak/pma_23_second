import java.util.LinkedList;
import java.util.List;

public class Matrix {
    private int rows;
    private int columns;
    private List<List<Double>> data;

    public Matrix() {
        rows = 0;
        columns = 0;
        data = new LinkedList<>();
    }

    public Matrix(int rows, int columns, List<List<Double>> data) {
        this.rows = rows;
        this.columns = columns;
        this.data = data;
    }

    public int getRows() {
        return rows;
    }

    public void setRows(int rows) {
        this.rows = rows;
    }

    public int getColumns() {
        return columns;
    }

    public void setColumns(int columns) {
        this.columns = columns;
    }

    public Double getElement(int row, int column) {
        return data.get(row).get(column);
    }

    public void setElement(int row, int column, Double value) {
        data.get(row).set(column, value);
    }

    public List<List<Double>> getData() {
        return data;
    }

    public void setData(List<List<Double>> data) {
        this.data = data;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder("Matrix:\n");

        for (List<Double> row : data) {
            for (Double element : row) {
                result.append(element).append(" ");
            }
            result.append("\n");
        }

        return result.toString();
    }
}