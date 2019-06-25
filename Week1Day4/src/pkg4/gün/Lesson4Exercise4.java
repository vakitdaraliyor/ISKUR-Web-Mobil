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
public class Lesson4Exercise4 {
    
    //######################################################################
    //                    EXERCISE - 3
    // Kullanicidan 5 tane sayi iste.
    // Girilen sayiyi isDuplicate fonksiyonu ile kontrol et.
    // Tekrar ediyorsa kabul etme tekrar iste.
    // Sayilari array de sakla.
    // Son array in elemanlarini ekrara bas.
    //######################################################################
    
    // Tekrar eden sayi var mı kontrol eder
    public static boolean isDuplicate(int sayi, int[] array){
        
        boolean check = false;
        
        for(int i = 0; i < array.length; i++){
            if(array[i] == sayi){
               check = true;
            } 
        }
        
        if(check){
            return true;
        }
        else{
            return false;
        }
        
    }
    
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        int[] array = new int[5];
        int counter = 0;
        int arrayIndex = 0;
        
        while(counter < array.length){
            
            System.out.print("Please enter 5 distinct number between 1 and 10: ");
            int userInput = input.nextInt();
            
            if(isDuplicate(userInput, array) == false){
                array[arrayIndex] = userInput;
                arrayIndex++;
                counter++;
            }
            else
                System.out.println("You can not duplicate number.Enter new number! ");;
            
            
            
        }
        System.out.print("Array elemanları: ");
        for(int i = 0; i < array.length; i++){
            System.out.print(array[i] + " ");
        }
            
    }
    
}
