/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package student.course.example;

/**
 *
 * @author AYBU
 */
public class Student {
    
    private String firstname;
    private String lastname;
    private int age;
    private int midterm1;
    private int midterm2;
    private int finalGrade;
    
    // -------------------------------------------------------------------------
    // Constructor    
    // -------------------------------------------------------------------------

    public Student(String firstname, String lastname, int age, int midterm1, int midterm2, int finalGrade) {
        setFirstname(firstname);
        setLastname(lastname);
        setAge(age);
        setMidterm1(midterm1);
        setMidterm2(midterm2);
        setFinalGrade(finalGrade);
    }
    
    // -------------------------------------------------------------------------
    // Methods    
    // -------------------------------------------------------------------------
    
    public double avarage(){
        return getMidterm1()*0.3 + getMidterm2()*0.3 + getFinalGrade()*0.4;
    }
    
    public String toString(){
        return "Student name: "     + getFirstname() + "\n" +
               "Student surname: "  + getLastname()+ "\n" +
               "Student age: "      + getAge()+ "\n" +
               "Student midterm1: " + getMidterm1()+ "\n" +
               "Student midterm2: " + getMidterm2()+ "\n" +
               "Student final: "    + getFinalGrade()+ "\n" +
               "Student avarage: "  + avarage()+ "\n";
    }

    // -------------------------------------------------------------------------
    // setters and getters    
    // -------------------------------------------------------------------------
    
    public String getFirstname() {
        return firstname;
    }

    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    public String getLastname() {
        return lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public int getMidterm1() {
        return midterm1;
    }

    public void setMidterm1(int midterm1) {
        this.midterm1 = midterm1;
    }

    public int getMidterm2() {
        return midterm2;
    }

    public void setMidterm2(int midterm2) {
        this.midterm2 = midterm2;
    }

    public int getFinalGrade() {
        return finalGrade;
    }

    public void setFinalGrade(int finalGrade) {
        this.finalGrade = finalGrade;
    }    
    
}
