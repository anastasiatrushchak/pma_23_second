package chargers;

import devices.TypeC;

public class TypeCCharger implements TypeC {
    public void connectToTypeC(){
        System.out.println("Connected to Type-C");
    }
}
