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
public class Lesson3Exercise3 {
    
    //##########################################################################
    //                    EXERCISE - 3
    // Fibonaci numbers 
    //##########################################################################
    
    // This function calculate fibonacci numbers
    public static void fibonacci(int limit){
        
        int[] array = new int[limit];
        array[1] = 1;
        
        for(int i = 2; i < limit; i++){
            array[i] = array[i-1] + array[i-2];
        }
        
        for(int i = 0; i < array.length; i++){
            System.out.print(array[i] + " ");
        }
        
    }
    
    // ------------------------- MAIN FUNCTION ------------------------------- 
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        int limit;
        
        System.out.print("Enter fibonacci number limit: ");
        limit = input.nextInt();
        
        fibonacci(limit);
        
    }
    
}
