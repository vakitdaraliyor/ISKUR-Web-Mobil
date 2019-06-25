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
public class Lesson8Exercise8 {
    
    //######################################################################
    //                    EXERCISE - 8
    //######################################################################
    
    public static int linearSearch(int[] list, int sayi){
        
        for(int i = 0; i < list.length; i++){
            if(list[i] == sayi){
                return i;
            }
        }
        return -1;
    }
    
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        int number;
        int[] numbersArray = {20, 50, 90};
        
        System.out.println("Enter a number: ");
        number = input.nextInt();
        
        System.out.println(linearSearch(numbersArray, number));
        
    }
    
}
