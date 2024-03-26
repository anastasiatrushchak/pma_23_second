package Pattern.ChainofResponsibility;



class Document {
    private String content;
    private int priority;

    public Document(String content, int priority) {
        this.content = content;
        this.priority = priority;
    }

    public String getContent() {
        return content;
    }

    public int getPriority() {
        return priority;
    }
}
