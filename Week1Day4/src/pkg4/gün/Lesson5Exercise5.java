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
public class Lesson5Exercise5 {
    
    //######################################################################
    //                    EXERCISE - 5
    // Girilen stringin uzunlugunu ve tersini erkana yazma
    //######################################################################
    
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        String word;
        String reverseWord="";
        
        System.out.print("Enter a string: ");
        word = input.nextLine();
        
        reverseWord = reverseString(word);
        
        System.out.println("\nEntered string: " + word);
        System.out.println("Entered string length: " + word.length());
        System.out.println("Reversed string: " + reverseWord);
   
    }

    public static String reverseString(String word) {
        String finalWord = word;
        word = "";
        for(int i = finalWord.length()-1; i >= 0; i--){
            //reverseKeyboard = reverseKeyboard.concat(keyboard.charAt(i)+"");
            word = word + finalWord.charAt(i);
        }
        return word;
    }
    
}
