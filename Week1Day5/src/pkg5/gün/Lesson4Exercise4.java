/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg5.gün;

import java.util.Scanner;

/**
 *
 * @author AYBU
 */
public class Lesson4Exercise4 {
    
    //##########################################################################
    //                    EXERCISE - 4
    // Compare DNA sequance 
    //##########################################################################
     
    // This function compares dna sequences 
    // and find similarties and differences
    public static void compare(String dna1, String dna2){
        
        double numOfDifference=0;
        double differenceRatio;
        double similarityRatio;
        
        for(int i = 0; i < dna1.length(); i++){
            
            if(dna1.charAt(i) == dna2.charAt(i)){
                System.out.println( (i+1) + ". index of dna's are not equal.");
                numOfDifference++;
            }
            else{
                System.out.println( (i+1) + ". index of dna's are equal.");
            }
        }
        
        differenceRatio = (numOfDifference / dna1.length());
        similarityRatio = (dna1.length()-numOfDifference) / dna1.length();
        
        System.out.println("Difference ratio is: " + differenceRatio);
        System.out.println("Similarty ratio is: " + similarityRatio);
    }
    
    // ------------------------- MAIN FUNCTION ------------------------------- 
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        String firstSequence;
        String secondSequence;
        
        // AATGGSSSAATTGTG
        // ATTGGASGAATSGTT
        
        System.out.print("Enter first DNA sequence: ");
        firstSequence = input.next();
        System.out.print("Enter second DNA sequence: ");
        secondSequence = input.next();
        
        compare(firstSequence, secondSequence);
    }       
    
}
