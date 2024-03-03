import java.util.ArrayList;

public class Sequence {

    private int steps = 0;
    private ArrayList<Integer> sequence;

    public Sequence( ArrayList<Integer> sequence) {
        this.steps = 0;
        this.sequence = sequence;
    }

    public int getSteps() {
        return steps;
    }

    public void setSteps(int steps) {
        this.steps = steps;
    }

    public ArrayList<Integer> getSequence() {
        return sequence;
    }

    public void addSequenceEl(Integer el){
        this.sequence.add(el);
    }

    @Override
    public String toString() {
        return "Sequence{" +
                "steps=" + steps +
                ", sequence=" + sequence +
                '}';
    }

    public String printSequence(){
        return "Sequence{sequence=" + sequence + '}';
    }
}
