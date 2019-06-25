/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg3.gün;

import java.util.Scanner;

/**
 *
 * @author AYBU
 */
public class Lesson1Exercise1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //######################################################################
        //                    EXERCISE - 1
        //######################################################################
        int ucret = 10000;
        for(int i = 1; i<=10; i++){
            
            System.out.println(i+")Ucret: " + ucret);
            
            int yillikUcret = ucret;
            int uniUcret = 0;
            
            for(int j=0; j<4; j++){
                uniUcret += yillikUcret;
                yillikUcret *= 1.05;
            }
            
            System.out.println(i + " - " + (i+3) + " Toplam ucret: " + uniUcret);
            
            ucret *= 1.05;
        }
        
    }
    
}
