/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bank;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author AYBU
 */
public class Test {
    
    public static void main(String[] args) {
        
        Operations op = new Operations();
    
        try {
            BufferedReader br = new BufferedReader(new FileReader(new File("C:\\Users\\AYBU\\Desktop\\input3.txt")));
            
            String line;
            
            while((line = br.readLine()) != null){                
                Person p = new Person(line);
                op.addPerson(p);
            }
            
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        
        op.getAllPersons();
        op.getAge(35);
        op.getCustomerBigger(3000);
        op.getJob("Doctor");
        op.isEligible(3000);
        
    }
    
}
