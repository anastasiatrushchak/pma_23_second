package Pattern.ChainofResponsibility;

public class Main {
    public static void main(String[] args) {
        ClerkHandler clerkHandler = new ClerkHandler();
        ManagerHandler managerHandler = new ManagerHandler();
        BossHandler bossHandler = new BossHandler();

        clerkHandler.setSuccessor(managerHandler);
        managerHandler.setSuccessor(bossHandler);


        Document document1 = new Document("Документ1", 2);
        Document document2 = new Document("Документ2", 5);
        Document document3 = new Document("Документ3", 8);


        clerkHandler.handleDocument(document1);
        clerkHandler.handleDocument(document2);
        clerkHandler.handleDocument(document3);
    }
}