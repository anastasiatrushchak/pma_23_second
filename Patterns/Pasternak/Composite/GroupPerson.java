package Pattern.Composite;

import java.util.ArrayList;
import java.util.List;

public class GroupPerson {
    List<Person> list = new ArrayList<>();
    public boolean add(Person newPerson){
       return list.add(newPerson);
    }
    public void printAllList(){
        list.forEach(x -> x.print());
    }
}
