package devices;

public class Phone {
    TypeC typeC;

    public Phone(TypeC typeC) {
        this.typeC = typeC;
    }

    public void connectToTypeC() {
        typeC.connectToTypeC();
    }
}
