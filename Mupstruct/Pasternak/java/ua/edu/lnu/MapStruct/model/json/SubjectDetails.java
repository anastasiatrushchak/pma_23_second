package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

public class SubjectDetails {
    @JsonProperty("subjectId")
    private String subjectId;

    @JsonProperty("teacher")
    private String teacher;

    @JsonProperty("countHours")
    private String countHours;

    @JsonProperty("ECTS")
    private String ECTS;

    @JsonProperty("semester")
    private String semester;

    @JsonProperty("isExam")
    private String isExam;


    public String getsubjectId() {
        return subjectId;
    }

    public String getteacher() {
        return teacher;
    }

    public String getcountHours() {
        return countHours;
    }

    public String getECTS() {
        return ECTS;
    }

    public String getsemester() {
        return semester;
    }

    public String getisExam() {
        return isExam;
    }
}
