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
public class Lesson8FonksiyonAlistirma2 {
    
    //Toplama fonksiyonu
    public static int sum(int x1, int x2){
        return x1+x2;
    }
    
    //Cıkarma fonksiyonu
    public static int sub(int x1, int x2){
        return x1-x2;
    }
    
    //Bolme fonksiyonu
    public static int div(int x1, int x2){
        return x1/x2;
    }
    
    //Carpma fonksiyonu
    public static int mult(int x1, int x2){
        return x1*x2;
    }
    
    
    // ------------------------- MAIN FONKSIYON --------------------------------
    public static void main(String[] args){
        
        Scanner input = new Scanner(System.in);
        int choice=0;
        int firstNumber;
        int secondNumber;
        
        while(choice != 5){
            System.out.println("Press 1 to summation \nPress 2 to subtraction \nPress 3 to division \nPress 4 to multipication \nPress 5 to exit");
            choice = input.nextInt();
            
            switch(choice){
                case 1:
                    System.out.print("Enter first number: ");
                    firstNumber = input.nextInt();
                    System.out.print("Enter second number: ");
                    secondNumber = input.nextInt();
                    
                    System.out.println("Sum: " + sum(firstNumber, secondNumber));
                    break;
                    
                case 2:
                    System.out.print("Enter first number: ");
                    firstNumber = input.nextInt();
                    System.out.print("Enter second number: ");
                    secondNumber = input.nextInt();
                    
                    System.out.println("sub: " + sub(firstNumber, secondNumber));
                    break;
                    
                case 3:
                    System.out.print("Enter first number: ");
                    firstNumber = input.nextInt();
                    System.out.print("Enter second number: ");
                    secondNumber = input.nextInt();
                    
                    System.out.println("Div: " + div(firstNumber, secondNumber));
                    break;
                    
                case 4:
                    System.out.print("Enter first number: ");
                    firstNumber = input.nextInt();
                    System.out.print("Enter second number: ");
                    secondNumber = input.nextInt();
                    
                    System.out.println("Mult: " + mult(firstNumber, secondNumber));
                    break;
                    
                default:
                    System.out.println("Program closed!");
                    break;
            }
        }
        
    }
    
}
