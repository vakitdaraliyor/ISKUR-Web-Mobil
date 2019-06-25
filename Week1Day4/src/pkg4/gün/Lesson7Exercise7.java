/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg4.gün;

import java.util.Scanner;

/**
 *
 * @author AYBU
 */
public class Lesson7Exercise7 {
    
    //######################################################################
    //                    EXERCISE - 7
    // split methodu ile verilen string i parcalama
    //######################################################################
    
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        String userInput;
        
        System.out.print("Enter a sentence: ");
        userInput = input.nextLine();
        
        String[] splitted = userInput.split(" ");
        
        System.out.println("Number of vocabulary: " + splitted.length);
        for(int i = 0; i < splitted.length; i++){
            System.out.println(splitted[i]);
        }
        
    }
    
}
