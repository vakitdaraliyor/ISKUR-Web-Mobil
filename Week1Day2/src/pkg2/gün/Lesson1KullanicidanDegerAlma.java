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
public class Lesson1KullanicidanDegerAlma {
    
    public static void main(String[] args){
        
        //######################################################################
        //--------------------- KULLANICIDAN DEĞER ALMA ------------------------
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        int userInputInt;
        String userInputString;
        
        System.out.println("------ İlk program başlıyor...------");
        
        System.out.print("Enter a number: ");
        userInputInt = input.nextInt();
        System.out.print("Enter a word: ");
        userInputString = input.next();
        
        System.out.println("Kullanıcının girdiği sayı: " + userInputInt);
        System.out.println("Kullanıcının girdiği kelime: " + userInputString);
        
    }
    
}
