package Pattern.ChainofResponsibility;

class ManagerHandler extends DocumentHandler {
    @Override
    public void handleDocument(Document document) {
        if (document.getPriority() <= 6) {
            System.out.println("Документ оброблено керівником відділення: " + document.getContent());
        } else if (successor != null) {
            successor.handleDocument(document);
        }
    }
}