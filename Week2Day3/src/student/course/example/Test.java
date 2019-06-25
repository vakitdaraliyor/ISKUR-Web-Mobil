/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package student.course.example;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.logging.Level;
import java.util.logging.Logger;
import jdk.nashorn.internal.objects.NativeArray;

/**
 *
 * @author AYBU
 */
public class Test {
    
    public static void main(String[] args) {
        try {
            
            Course c1 = new Course("Math");
            Course c2 = new Course("Chem");
            
            BufferedReader br = new BufferedReader(new FileReader(new File("C:\\Users\\AYBU\\Desktop\\input1.txt")));
            
            String line;
            Student s;
            
            while((line = br.readLine()) != null){
                String[] splitted = line.split(" ");
                
                s = new Student(splitted[0], splitted[1], 
                                Integer.parseInt(splitted[3]), 
                                Integer.parseInt(splitted[4]), 
                                Integer.parseInt(splitted[5]), 
                                Integer.parseInt(splitted[6]));
                
                if(splitted[2].equals("Math")){
                    c1.addStudent(s);
                }else{
                    c2.addStudent(s);
                }
            }
            
            c1.list();
            c2.list();
            
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }
    
}
