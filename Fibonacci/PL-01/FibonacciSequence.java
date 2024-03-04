package lnu;

import java.util.ArrayList;
import java.util.List;

public class FibonacciSequence {
    private List<Integer> sequence;
    private int steps;

    public FibonacciSequence() {
        sequence = new ArrayList<>();
        steps = 0;
    }

    public List<Integer> getSequence() {
        return sequence;
    }

    public int getSteps() {
        return steps;
    }

    public void setSequence(List<Integer> sequence) {
        this.sequence = sequence;
    }

    public void setSteps(int steps) {
        this.steps = steps;
    }
}


