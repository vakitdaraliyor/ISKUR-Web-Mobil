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
public class Lesson2Exercise2 {
    
    public static void main(String[] args) {
        // TODO code application logic here
        //######################################################################
        //                    EXERCISE - 2
        // Kullanicidan isim ve integer deger al. En büyük ilk 2 tane sayi ve isimi yaz
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        
        int counter = 0;
        
        int maxScore = 0;
        int secondScore = 0;
        int temp;
        
        String firstUser="";
        String secondUser="";
        
        while(counter != 5){
            
            System.out.print("Enter username: ");
            String username = input.next();
            System.out.print("Enter score: ");
            int score = input.nextInt();
            
            if(score > maxScore){
                secondUser = firstUser;
                firstUser = username;
                secondScore = maxScore;
                maxScore = score;
            }    
            else if(score > secondScore){
                secondUser = username;
                secondScore = score; 
            }
        
            counter++;
            
        }
        System.out.println("\nMax score: " + maxScore + " Username: " + firstUser);
        System.out.println("Second score: " + secondScore + " Username: " + secondUser);
        
    }
}
