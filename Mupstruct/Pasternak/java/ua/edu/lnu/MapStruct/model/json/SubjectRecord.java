package ua.edu.lnu.MapStruct.model.json;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.util.List;

public class SubjectRecord {
    @JsonProperty("SubjectId")
    private String SubjectId;

    @JsonProperty("SubjectDetails")
    private SubjectDetails SubjectDetails;

    @JsonProperty("StudentDetails")
    private List<StudentDetails> StudentDetails;

    public String getSubjectId() {
        return SubjectId;
    }

    public SubjectDetails getSubjectDetails() {
        return SubjectDetails;
    }

    public List<StudentDetails> getStudentDetails() {
        return StudentDetails;
    }

}