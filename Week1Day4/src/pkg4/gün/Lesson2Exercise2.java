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
public class Lesson2Exercise2 {
    
    //##########################################################################
    //                    EXERCISE - 2
    // Check your password valid or not
    //##########################################################################
    
    // This function check password is valid or not
    public static boolean isValid(String password){
        
        int numOfDigits = 0; 
        boolean check = false;
        boolean isOnlyLetterOrDigit = false;
        String trimPassword = password.trim();
        
        // Password icinde kac sayi var onu bulur(numOfDigits => number of digits)
        for(int i = 0; i < trimPassword.length(); i++){
            if(Character.isDigit(trimPassword.charAt(i)) == true){
                numOfDigits++;
            }
        }
        
        // Regular expression kullanarak 
        // Password icinde yalniz sayi veya karakter oldugunu kontrol etme
        isOnlyLetterOrDigit = trimPassword.matches(".*[a-zA-Z].*") || trimPassword.matches(".*[0-9].*");
        
        // Password olmanin sartlari:
        // 1) Password uzunlugu en az 8 karakter olmali.
        // 2) Password icerisinde en az 2 sayi bulunmali.
        // 3) Password sadece harf ve sayilardan olusmali.
        if((trimPassword.length() >= 8) && (numOfDigits >= 2)){
            if(isOnlyLetterOrDigit){
                check = true;
            }
            else{
                check = false;
            }
        }
        
        if(check){
            return true;
        }
        else{
            return false;
        }
        
    }
    
    // -------------------------- MAIN FUNCTION -------------------------------- 
    public static void main(String[] args) {
    
        Scanner input = new Scanner(System.in);
        
        String userPassword;
        
        System.out.print("Enter your password: ");
        userPassword = input.nextLine();
        
        if(isValid(userPassword)){
            System.out.println("Your password is vaild.");
        }
        else{
            System.out.println("Your password is not vaild.");
        }
        
    }
    
}
