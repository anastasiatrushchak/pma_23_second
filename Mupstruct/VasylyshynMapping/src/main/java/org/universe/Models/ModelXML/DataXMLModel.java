package org.universe.Models.ModelXML;

import javax.xml.bind.annotation.*;
import java.util.List;

@XmlRootElement(name = "Data")
@XmlAccessorType(XmlAccessType.FIELD)
public class DataXMLModel {
    @XmlAttribute(name = "indentificatorId")
    private String identificatorId;
    @XmlElement(name = "dataItem")
    private DataItemXMLModel dataItem;
    @XmlElementWrapper(name = "infos")
    @XmlElement(name = "info")
    private List<InfoXMLModel> info;

    public String getIdentificatorId() {
        return identificatorId;
    }

    public DataXMLModel setIdentificatorId(String identificatorId) {
        this.identificatorId = identificatorId;
        return this;
    }

    public DataItemXMLModel getDataItem() {
        return dataItem;
    }

    public DataXMLModel setDataItem(DataItemXMLModel dataItem) {
        this.dataItem = dataItem;
        return this;
    }

    public List<InfoXMLModel> getInfos() {
        return info;
    }

    public DataXMLModel setInfos(List<InfoXMLModel> infos) {
        this.info = infos;
        return this;
    }
}
