import chargers.LightningCharger;
import chargers.TypeCCharger;
import devices.LightningToCAdapter;
import devices.Phone;
import devices.TypeC;

public class Main {
    public static void main(String[] args) {
        Phone phone = new Phone(new TypeCCharger());
        phone.connectToTypeC();


        Phone phone2 = new Phone(new LightningToCAdapter(new LightningCharger()));
        phone2.connectToTypeC();
    }
}
