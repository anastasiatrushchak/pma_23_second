import Shoes.Adidas;
import Shoes.*;

public class ShoeFactory {
    public static Shoe makeShoe(String shoeBrand) {
        switch (shoeBrand.toLowerCase()) {
            case "adidas" -> {
                return new Adidas();
            }
            case "nike" -> {
                return new Nike();
            }
            case "converse" -> {
                return new Converse();
            }
            default -> throw new RuntimeException("Can't make shoe " + shoeBrand);
        }
    }
}
