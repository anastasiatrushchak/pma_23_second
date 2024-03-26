package Pattern.ChainofResponsibility;


class ClerkHandler extends DocumentHandler {
  @Override
    public void handleDocument(Document document) {
        if (document.getPriority() <= 3) {
            System.out.println("Документ оброблено клерком: " + document.getContent());
        } else if (successor != null) {
            successor.handleDocument(document);
        }
    }
}