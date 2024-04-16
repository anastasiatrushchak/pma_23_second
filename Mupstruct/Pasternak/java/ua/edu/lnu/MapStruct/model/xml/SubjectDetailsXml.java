package ua.edu.lnu.MapStruct.model.xml;

import jakarta.xml.bind.annotation.XmlElement;
import jakarta.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "SubjectDetails")
public class SubjectDetailsXml {
    private String subjectId;
    private String teacher;
    private String countHours;
    private String ECTS;
    private String semester;
    private String isExam;

    @XmlElement(name = "subjectId")
    public String getsubjectId() {
        return subjectId;
    }

    public void setsubjectId(String subjectId) {
        this.subjectId = subjectId;
    }

    @XmlElement(name = "teacher")
    public String getteacher() {
        return teacher;
    }

    public void setteacher(String teacher) {
        this.teacher = teacher;
    }

    @XmlElement(name = "countHours")
    public String getcountHours() {
        return countHours;
    }

    public void setcountHours(String countHours) {
        this.countHours = countHours;
    }

    @XmlElement(name = "ECTS")
    public String getECTS() {
        return ECTS;
    }

    public void setECTS(String ECTS) {
        this.ECTS = ECTS;
    }

    @XmlElement(name = "semester")
    public String getsemester() {
        return semester;
    }

    public void setsemester(String semester) {
        this.semester = semester;
    }

    @XmlElement(name = "isExam")
    public String getisExam() {
        return isExam;
    }

    public void setisExam(String isExam) {
        this.isExam = isExam;
    }
}