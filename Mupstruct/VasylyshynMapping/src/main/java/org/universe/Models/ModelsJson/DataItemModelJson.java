package org.universe.Models.ModelsJson;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;


@JsonIgnoreProperties(ignoreUnknown = true)
public class DataItemModelJson {
    private String objectId;
    private String effectimeFrom;
    private String effectiveTo;
    private String someUselessStuff;

    @JsonCreator
    public DataItemModelJson(@JsonProperty("objectId") String objectId,
                             @JsonProperty("effectimeFrom") String effectimeFrom,
                             @JsonProperty("effectiveTo") String effectiveTo,
                             @JsonProperty("someUselessStuff") String someUselessStuff) {
        this.objectId = objectId;
        this.effectimeFrom = effectimeFrom;
        this.effectiveTo = effectiveTo;
        this.someUselessStuff = someUselessStuff;
    }

    public String getObjectId() {
        return objectId;
    }

    public DataItemModelJson setObjectId(String objectId) {
        this.objectId = objectId;
        return this;
    }

    public String getEffectimeFrom() {
        return effectimeFrom;
    }

    public DataItemModelJson setEffectimeFrom(String effectimeFrom) {
        this.effectimeFrom = effectimeFrom;
        return this;
    }

    public String getEffectiveTo() {
        return effectiveTo;
    }

    public DataItemModelJson setEffectiveTo(String effectiveTo) {
        this.effectiveTo = effectiveTo;
        return this;
    }

    public String getSomeUselessStuff() {
        return someUselessStuff;
    }

    public DataItemModelJson setSomeUselessStuff(String someUselessStuff) {
        this.someUselessStuff = someUselessStuff;
        return this;
    }

    @Override
    public String toString() {
        return "DataItem{" +
                "objectId='" + objectId + '\'' +
                ", effectimeFrom='" + effectimeFrom + '\'' +
                ", effectiveTo='" + effectiveTo + '\'' +
                ", someUselessStuff=" + someUselessStuff +
                '}';
    }
}
