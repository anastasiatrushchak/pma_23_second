final class Service {

    public static void borderAlg(int border, Sequence fs){
        int topIndex = fs.getSequence().size() - 1;
        int nextEl = fs.getSequence().get(topIndex) + fs.getSequence().get(--topIndex);

        if (nextEl < border){
            fs.addSequenceEl(nextEl);
            fs.setSteps(fs.getSteps() + 1);
            borderAlg(border, fs);
        }
    }

    public static void stepsAlg(int steps, Sequence fs){
        int topIndex = fs.getSequence().size() - 1;
        int nextEl = fs.getSequence().get(topIndex) + fs.getSequence().get(--topIndex);

        if (fs.getSteps() > steps){
            fs.addSequenceEl(nextEl);
            fs.setSteps(fs.getSteps() + 1);
            stepsAlg(steps, fs);
        }
    }
}
