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
public class Lesson4Exercise4 {
    public static void main(String[] args) {
        // TODO code application logic here
        //######################################################################
        //                    EXERCISE - 4
        // Kullanicinin girdigi string in tek indexteki karakterini ekrana bas
        // Ex: galatasaray => gltsry
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        System.out.println("Enter a string: ");
        String userInput = input.nextLine();
        
        for(int i = 0; i < userInput.length(); i+=2){
            System.out.print(userInput.charAt(i));
        }
        System.out.println("\n");
    }
}
