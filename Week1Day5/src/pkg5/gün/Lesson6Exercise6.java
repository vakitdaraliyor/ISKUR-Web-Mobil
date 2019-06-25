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
public class Lesson6Exercise6 {
    
    //##########################################################################
    //                    EXERCISE - 5
    // Fibonacci recursive
    // Factoriel recursive
    //##########################################################################
    
    public static int recursiveFibonacci(int number){
        if(number == 0 || number == 1){
            return number;
        }
        else{
            return recursiveFibonacci(number-1) + recursiveFibonacci(number-2);
        }
    }
    
    public static int recursiveFactoriel(int number){
        if(number == 1){
            return 1;
        }
        else{
            return number * recursiveFactoriel(number-1);
        }
    }
    
    public static int recursivePow(int number, int root){
        if(root == 0){
            return 1;
        }
        else if(root == 1){
            return number;
        }
        else{
            return number * recursivePow(number, root-1);
        }
    }
    
    // -------------------------- MAIN FUNCTION -------------------------------- 
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        int number;
        int counter = 0;
        
        System.out.print("Enter fibonacci limit: ");
        number = input.nextInt();
        
        while(counter <= number){
            System.out.print(recursiveFibonacci(counter) + " ");
            counter++;
        }
        
        System.out.println("\nFactoriel: " + recursiveFactoriel(number));
        System.out.println("Pow: " + recursivePow(3, 0));
        System.out.println("Pow: " + recursivePow(3, 5));
        System.out.println("Pow: " + recursivePow(2, 6));
        
    }
    
}
