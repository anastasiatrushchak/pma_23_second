package org.universe.Models.ModelXML;


import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;

@XmlAccessorType(XmlAccessType.FIELD)
public class DataItemXMLModel {
    @XmlAttribute(name = "objectId")
    private String objectId;
    @XmlElement(name = "effectimeFrom")
    private String effectimeFrom;
    @XmlElement(name = "effectiveTo")
    private String effectiveTo;
    @XmlElement(name = "someUselessStuff")
    private String someUselessStuff;

    public String getObjectId() {
        return objectId;
    }

    public DataItemXMLModel setObjectId(String objectId) {
        this.objectId = objectId;
        return this;
    }

    public String getEffectimeFrom() {
        return effectimeFrom;
    }

    public DataItemXMLModel setEffectimeFrom(String effectimeFrom) {
        this.effectimeFrom = effectimeFrom;
        return this;
    }

    public String getEffectiveTo() {
        return effectiveTo;
    }

    public DataItemXMLModel setEffectiveTo(String effectiveTo) {
        this.effectiveTo = effectiveTo;
        return this;
    }

    public String getSomeUselessStuff() {
        return someUselessStuff;
    }

    public DataItemXMLModel setSomeUselessStuff(String someUselessStuff) {
        this.someUselessStuff = someUselessStuff;
        return this;
    }
}
