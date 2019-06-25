/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package student.course.example;

import java.util.ArrayList;

/**
 *
 * @author AYBU
 */
public class Course {
    
    private String courseName;
    private ArrayList<Student> studentList;
    private int numberOfStudent;

    // -------------------------------------------------------------------------
    // Constructor    
    // -------------------------------------------------------------------------
    public Course(String coursename){
        setCourseName(coursename);
        this.studentList = new ArrayList<Student>();
    }

    // -------------------------------------------------------------------------
    // Methods    
    // -------------------------------------------------------------------------
    public void addStudent(Student student){
        getStudentList().add(student);
        numberOfStudent++;
    }
    
    public void list(){
        System.out.println("<----- " + getCourseName()+ " Course ----->");
        System.out.println("Number of student: " + getNumberOfStudent() +"\n");
        for(int i = 0; i < getStudentList().size(); i++){
            System.out.println(getStudentList().get(i).toString());
        }
    }
    
    // -------------------------------------------------------------------------
    // setters and getters    
    // -------------------------------------------------------------------------

    public String getCourseName() {
        return courseName;
    }

    public void setCourseName(String courseName) {
        this.courseName = courseName;
    }

    public ArrayList<Student> getStudentList() {
        return studentList;
    }

    public void setStudentList(ArrayList<Student> studentList) {
        this.studentList = studentList;
    }

    public int getNumberOfStudent() {
        return numberOfStudent;
    }

    public void setNumberOfStudent(int numberOfStudent) {
        this.numberOfStudent = numberOfStudent;
    }
      
}
