package org.universe.Models.ModelXML;

import javax.xml.bind.annotation.*;
import java.util.List;

@XmlAccessorType(XmlAccessType.FIELD)
public class InfoXMLModel {
    @XmlAttribute(name = "TwoUselessFielsd")
    private String TwoUselessFielsd;
    @XmlElement(name = "currentAt")
    private String currentAt;
    @XmlElement(name = "CurrentFrom")
    private String CurrentFrom;
    @XmlElement(name = "type")
    private String type;
    @XmlElementWrapper(name = "ThreeMoreUselessFields")
    @XmlElement(name = "fild")
    private List<String> ThreeMoreUselessFields;

    public String getTwoUselessFielsd() {
        return TwoUselessFielsd;
    }

    public InfoXMLModel setTwoUselessFielsd(String twoUselessFielsd) {
        TwoUselessFielsd = twoUselessFielsd;
        return this;
    }

    public String getCurrentAt() {
        return currentAt;
    }

    public InfoXMLModel setCurrentAt(String currentAt) {
        this.currentAt = currentAt;
        return this;
    }

    public String getCurrentFrom() {
        return CurrentFrom;
    }

    public InfoXMLModel setCurrentFrom(String currentFrom) {
        CurrentFrom = currentFrom;
        return this;
    }

    public String getType() {
        return type;
    }

    public InfoXMLModel setType(String type) {
        this.type = type;
        return this;
    }

    public List<String> getThreeMoreUselessFields() {
        return ThreeMoreUselessFields;
    }

    public InfoXMLModel setThreeMoreUselessFields(List<String> threeMoreUselessFields) {
        ThreeMoreUselessFields = threeMoreUselessFields;
        return this;
    }
}
