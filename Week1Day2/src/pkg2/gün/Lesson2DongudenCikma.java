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
public class Lesson2DongudenCikma {
    
    public static void main(String[] args){
        
        //######################################################################
        //--------- KULLANICI NEGATİF SAYI GİRDİĞİNDE DÖNGÜDEN ÇIK -----------
        //######################################################################
        
        
        Scanner input = new Scanner(System.in);
        int userInputInt;
        
        System.out.print("Enter a number: ");
        userInputInt = input.nextInt();
        
        System.out.println("------ İkinci program başlıyor... ------");
        System.out.println("Negatif sayı girildiğinde program kapatılır.");
        while(userInputInt >= 0){
            System.out.print("Enter number: ");
            userInputInt = input.nextInt();
        }
        
        System.out.println("Program closed!");
        
    }
    
}
