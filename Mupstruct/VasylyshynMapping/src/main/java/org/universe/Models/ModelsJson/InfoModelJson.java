package org.universe.Models.ModelsJson;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.List;

@JsonIgnoreProperties(ignoreUnknown = true)

public class InfoModelJson {
    private String TwoUselessFielsd;
    private String currentAt;
    private String CurrentFrom;
    private String type;
    private List<String> ThreeMoreUselessFields;

    @JsonCreator
    public InfoModelJson(@JsonProperty("TwoUselessFielsd") String TwoUselessFielsd,
                         @JsonProperty("currentAt") String currentAt,
                         @JsonProperty("CurrentFrom") String CurrentFrom,
                         @JsonProperty("type") String type,
                         @JsonProperty("ThreeMoreUselessFields") List<String> ThreeMoreUselessFields) {
        this.TwoUselessFielsd = TwoUselessFielsd;
        this.currentAt = currentAt;
        this.CurrentFrom = CurrentFrom;
        this.type = type;
        this.ThreeMoreUselessFields = ThreeMoreUselessFields;
    }

    public String getTwoUselessFielsd() {
        return TwoUselessFielsd;
    }

    public InfoModelJson setTwoUselessFielsd(String twoUselessFielsd) {
        TwoUselessFielsd = twoUselessFielsd;
        return this;
    }

    public String getCurrentAt() {
        return currentAt;
    }

    public InfoModelJson setCurrentAt(String currentAt) {
        this.currentAt = currentAt;
        return this;
    }

    public String getCurrentFrom() {
        return CurrentFrom;
    }

    public InfoModelJson setCurrentFrom(String currentFrom) {
        CurrentFrom = currentFrom;
        return this;
    }

    public String getType() {
        return type;
    }

    public InfoModelJson setType(String type) {
        this.type = type;
        return this;
    }

    public List<String> getThreeMoreUselessFields() {
        return ThreeMoreUselessFields;
    }

    public InfoModelJson setThreeMoreUselessFields(List<String> threeMoreUselessFields) {
        ThreeMoreUselessFields = threeMoreUselessFields;
        return this;
    }

    @Override
    public String toString() {
        return "InfoModelJson{" +
                "TwoUselessFielsd='" + TwoUselessFielsd + '\'' +
                ", currentAt='" + currentAt + '\'' +
                ", CurrentFrom='" + CurrentFrom + '\'' +
                ", type='" + type + '\'' +
                ", ThreeMoreUselessFields=" + ThreeMoreUselessFields +
                '}';
    }
}
