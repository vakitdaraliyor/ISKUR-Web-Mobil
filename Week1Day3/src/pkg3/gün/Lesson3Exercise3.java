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
public class Lesson3Exercise3 {
    
    public static void main(String[] args) {
        // TODO code application logic here
        //######################################################################
        //                    EXERCISE - 3
        // Kullanicinin girdigi sayilardan maksimum olanin kac kere tekrar ettigini bul
        // Ex: 2 5 5 5 3 1 2 => Max number: 5 Count: 3
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        int counter = 0;
        int maxScore = 0;
        int secondScore = 0;
        
        for(int i = 0; i < 10; i++){
            System.out.print("Enter score: ");
            int score = input.nextInt();
            
            if(score > maxScore){
                secondScore = maxScore;
                maxScore = score;
                counter=0;
            }
            if(score == maxScore){
                counter++;
            }
            else if(score > secondScore){
                secondScore = score;
            }
        }
        
        System.out.println("\nMax score: " + maxScore + " Count: " + counter + "\n");

    }
}
