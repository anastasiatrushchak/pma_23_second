package devices;

import chargers.LightningCharger;

public class LightningToCAdapter implements TypeC{
    private LightningCharger lightning;

    public LightningToCAdapter(LightningCharger lightning) {
        this.lightning = lightning;
    }

    public void connectToTypeC() {
        lightning.connectToLightning();
    }
}
