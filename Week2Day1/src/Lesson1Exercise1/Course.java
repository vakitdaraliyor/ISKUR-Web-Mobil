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
//                      Normal Array Kullanıldı
//##############################################################################

public class Course {
    
    private String courseName;
    private String[] students;
    private static int numberOfStudents = 0;
    
    public Course(String courseName){
        this.courseName = courseName;
        students = new String[10];
    }
    
    public void addStudent(String student){
        students[numberOfStudents] = student;
        numberOfStudents++;
    }
    
    public void dropStudent(String student){
        boolean check = true;
        
        for(int i = 0 ; i < students.length; i ++){
            if(students[i] == student){
                for(int j = i; i < students.length - 1; i++){
                    students[i] = students[i+1];
                }
            }
            else{
                check = false;
            }
        }
        if(check==false){
            System.out.println(student + " does not exist!");
        }
        
        numberOfStudents--;
    }

    public String getCourseName() {
        return courseName;
    }

    public void setCourseName(String courseName) {
        this.courseName = courseName;
    }

    public String[] getStudents() {
        return students;
    }

    public void setStudents(String[] students) {
        this.students = students;
    }

    public static int getNumberOfStudents() {
        return numberOfStudents;
    }

    public static void setNumberOfStudents(int numberOfStudents) {
        Course.numberOfStudents = numberOfStudents;
    }

}
