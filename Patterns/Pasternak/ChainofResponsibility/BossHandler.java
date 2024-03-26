package Pattern.ChainofResponsibility;

class BossHandler extends DocumentHandler {
    @Override
    public void handleDocument(Document document) {
        if (document.getPriority() <= 10) {
            System.out.println("Документ оброблено керівником банку: " + document.getContent());
        } else {
            System.out.println("Документ відхилений: " + document.getContent());
        }
    }
}