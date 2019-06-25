/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg4.gün;

/**
 *
 * @author AYBU
 */
public class Lesson6Exercise6 {
    
    //######################################################################
    //                    EXERCISE - 6
    // Girilen stringin uzunlugunu ve tersini erkana yazma
    //######################################################################
    
    public static void main(String[] args) {
        
        String letters = "abcdefghijklmabcdefghijklm";
        String twentyToEnd = "";
        String threeToSix = "";
        
        // First way using substring() function 
        System.out.println("<--- First way using substring function --->");
        System.out.print("Substring from index 20 to end is: " + letters.substring(20) + "\n");
        System.out.print("Substring from index 3 up to, but not including 6 is: " + letters.substring(3, 6) + "\n");
        
        // Second way do not using substring function
        // Using for loop and charAt() function
        for(int i = 0; i < letters.length(); i++){
            if(i >= 20){
                twentyToEnd = twentyToEnd + letters.charAt(i);
            }
            if(i<6 && i>2){
                threeToSix = threeToSix + letters.charAt(i);
            }
        }
        
        System.out.println("\n<--- Second way do not using substring function --->");
        System.out.print("Substring from index 20 to end is: " + twentyToEnd + "\n");
        System.out.print("Substring from index 3 up to, but not including 6 is: " + threeToSix + "\n");
        
    }
    
}
