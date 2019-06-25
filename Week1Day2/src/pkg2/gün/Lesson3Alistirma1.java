/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg2.gün;

import java.util.Scanner;

/**
 *
 * @author AYBU
 */
public class Lesson3Alistirma1 {
    
    public static void main(String[] args){        
        
        Scanner input = new Scanner(System.in);
        
        //######################################################################
        //--------------------- ALIŞTIRMA - 1 ------------------------
        //######################################################################
        
        double weight, initialTemp, finalTemp, result;
        
        System.out.print("Enter the amount of water in kilograms: ");
        weight = input.nextDouble();
        System.out.print("Enter the initial temperature: ");
        initialTemp = input.nextDouble();
        System.out.print("Enter the final temperature: ");
        finalTemp = input.nextDouble();
        
        result = weight * (finalTemp - initialTemp) * 4184;
        
        System.out.println("The energy needed is: " + result);
        
    }    
    
}
