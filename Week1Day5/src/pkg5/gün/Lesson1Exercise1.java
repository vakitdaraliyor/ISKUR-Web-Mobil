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
public class Lesson1Exercise1 {

    /**
     * @param args the command line arguments
     */
    
    //##########################################################################
    //                    EXERCISE - 1
    // Take two side from user and find hypotenuse 
    //##########################################################################
    
    // This function calculates hypotenus
    public static double calculateHipo(int side1, int side2){
        return Math.sqrt(Math.pow(side1, 2) + Math.pow(side2, 2));
    }
    
    // ------------------------- MAIN FUNCTION -------------------------------
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        int side1;
        int side2;
        double hypotenuse;
        
        System.out.print("Enter first side: ");
        side1 = input.nextInt();
        System.out.print("Enter second side: ");
        side2 = input.nextInt();
        
        hypotenuse = calculateHipo(side1, side2);
        
        System.out.println("Hypotenuse: " + hypotenuse);
        
    }
    
}
