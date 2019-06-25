/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2day4;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author AYBU
 */
public class Test {
    
    public static void main(String[] args) {
        
        OperationsClass oc = new OperationsClass();  
        
        try {
            BufferedReader br = new BufferedReader(new FileReader(new File("C:\\Users\\AYBU\\Desktop\\input2.txt")));
            
            String line;
            
            while((line = br.readLine()) != null){                
                Person p = new Person(line);
                oc.addPerson(p);
            }
            
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        
        oc.getList();
        System.out.println("<---- Search by id ---->");
        oc.searchById("33333333");
        System.out.println("<---- Search by name ---->");
        oc.searchByName("Osman");
        System.out.println("<---- Search by city ---->");
        oc.searchByCity("Ankara");
        
    }
    
}
