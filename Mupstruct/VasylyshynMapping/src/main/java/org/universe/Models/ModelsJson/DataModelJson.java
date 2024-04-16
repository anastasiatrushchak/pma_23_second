package org.universe.Models.ModelsJson;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import org.bson.types.ObjectId;
import org.universe.Deserealizers.ObjectIdDeserializer;

import java.util.List;

@JsonIgnoreProperties(ignoreUnknown = true)

public class DataModelJson {
    @JsonDeserialize(using = ObjectIdDeserializer.class)
    private ObjectId _id;
    private String identificatorId;
    private DataItemModelJson dataItem;
    private List<InfoModelJson> info;

    @JsonCreator
    public DataModelJson(@JsonProperty("_id") ObjectId _id,
                         @JsonProperty("identificatorId") String identificatorId,
                         @JsonProperty("dataItem") DataItemModelJson dataItem,
                         @JsonProperty("info") List<InfoModelJson> info) {
        this._id = _id;
        this.identificatorId = identificatorId;
        this.dataItem = dataItem;
        this.info = info;
    }

    public ObjectId get_id() {
        return _id;
    }

    public String getIdentificatorId() {
        return identificatorId;
    }

    public DataItemModelJson getDataItem() {
        return dataItem;
    }

    public List<InfoModelJson> getInfo() {
        return info;
    }
}
