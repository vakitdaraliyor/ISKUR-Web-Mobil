/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lesson1Exercise1;

import java.util.ArrayList;

/**
 *
 * @author AYBU
 */

//##############################################################################
//                          EXERCISE - 1 
//                      ArrayList Kullanıldı
//##############################################################################

public class Course2 {
    
    private String courseName;
    private ArrayList<String> students;
    private static int numberOfStudents = 0;
    
    public Course2(String courseName){
        this.courseName = courseName;
        students = new ArrayList<>();
    }
    
    public void addStudent(String student){
        students.add(student);
        numberOfStudents++;
    }
    
    public void dropStudent(String student){
        
        if(students.contains(student)){
            students.remove(student);
        }
        else{
            System.out.println(student + " does not exist!.");
        }
        
        numberOfStudents--;
    }

    public String getCourseName() {
        return courseName;
    }

    public void setCourseName(String courseName) {
        this.courseName = courseName;
    }

    public ArrayList<String> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<String> students) {
        this.students = students;
    }    

    public static int getNumberOfStudents() {
        return numberOfStudents;
    }

    public static void setNumberOfStudents(int numberOfStudents) {
        Course2.numberOfStudents = numberOfStudents;
    }
    
}
