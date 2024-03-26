package Pattern.ChainofResponsibility;

abstract class DocumentHandler {
    protected DocumentHandler successor;

    public void setSuccessor(DocumentHandler successor) {
        this.successor = successor;
    }

    public abstract void handleDocument(Document document);
}