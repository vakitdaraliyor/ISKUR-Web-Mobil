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
public class Lesson5Exercise5 {
    
    public static void main(String[] args) {
        // TODO code application logic here
        //######################################################################
        //                    EXERCISE - 5
        // Boy kilo indeksi hesaplama programi
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        double[][] body = new double[5][5];
        
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 2; j++){
                if(j == 0){
                    System.out.print("Enter " + (i+1) + ". person's height: ");
                    double height = input.nextDouble();
                    body[i][j] = height;
                }
                else if(j == 1){
                    System.out.print("Enter " + (i+1) + ". person's weight: ");
                    double weight = input.nextDouble();
                    body[i][j] = weight;
                }    
            } 
        }
        
        double vki=0;
        for(int i = 0; i < 3; i++){
                
            vki = body[i][1]/Math.pow((body[i][0]),2);

            System.out.println((i+1) + ". person's VKI: " + vki);
            
            if(vki > 25){
                System.out.println((i+1) + ". person is obez");
            }
            else if(vki > 20){
                System.out.println((i+1) + ". person is kilolu");
            }
            else if(vki > 15){
                System.out.println((i+1) + ". person is normal");
            }
            else if(vki > 10){
                System.out.println((i+1) + ". person is zayif");
            }
            else{
                System.out.println((i+1) + ". person is ölü");
            }
        }
    }
}
