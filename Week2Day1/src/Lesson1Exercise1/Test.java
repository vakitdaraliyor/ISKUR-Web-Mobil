/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lesson1Exercise1;

/**
 *
 * @author AYBU
 */

//##############################################################################
//                          EXERCISE - 1 
//                      Normal Array Kullanıldı
//##############################################################################

public class Test {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.println("\n<--- Normal Array Test --->");
        Course c1 = new Course("Mathematic");
        
        c1.addStudent("Osman");
        c1.addStudent("Ali");
        c1.addStudent("Ahmet");
        c1.addStudent("Hasan");
        c1.addStudent("Tarık");
        
        c1.dropStudent("Osman");
        c1.dropStudent("Tufan");
        //c1.dropStudent("Hasan");
        
        System.out.println("Course name: " + c1.getCourseName());
        
        System.out.print("Students: ");
        for(int i = 0; i < c1.getNumberOfStudents(); i++){
            System.out.print(c1.getStudents()[i] + " ");
        }
        
        System.out.println("\nNumber of Students: " + c1.getNumberOfStudents());
        
        
//##############################################################################
//                          EXERCISE - 1 
//                      ArrayList Kullanıldı
//##############################################################################
        System.out.println("\n<--- ArrayList Test --->");
        Course2 c = new Course2("Programming");
        
        c.addStudent("Orhan");
        c.addStudent("Arif");
        c.addStudent("Tekin");
        c.addStudent("Hüseyin");
        c.addStudent("Yusuf");
        
        c.dropStudent("Orhan");
        c.dropStudent("Tufan");
        //c1.dropStudent("Hasan");
        
        System.out.println("Course name: " + c.getCourseName());
        
        System.out.println(c.getStudents());
        System.out.print("Students: ");
        for(int i = 0; i < c.getNumberOfStudents(); i++){
            System.out.print(c.getStudents().get(i) + " ");
        }
        
        System.out.println("\nNumber of Students: " + c.getNumberOfStudents());
        
    }
    
}
