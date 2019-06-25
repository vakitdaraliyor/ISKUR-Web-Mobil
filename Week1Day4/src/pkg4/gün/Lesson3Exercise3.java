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
public class Lesson3Exercise3 {
    
    //######################################################################
    //                    EXERCISE - 3
    //######################################################################
    
    public static void main(String[] args) {
    
        int[] gradesArray = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
        int[] starArray = new int[11];
        
        for(int i = 0; i < gradesArray.length; i++){
            if(gradesArray[i] >= 100){
                starArray[starArray.length - 1]++; 
            }
            else if(gradesArray[i] >= 90){
                starArray[starArray.length - 2]++; 
            }
            else if(gradesArray[i] >= 80){
                starArray[starArray.length - 3]++; 
            }
            else if(gradesArray[i] >= 70){
                starArray[starArray.length - 4]++; 
            }
            else if(gradesArray[i] >= 60){
                starArray[starArray.length - 5]++; 
            }
            else if(gradesArray[i] >= 50){
                starArray[starArray.length - 6]++; 
            }
            else if(gradesArray[i] >= 40){
                starArray[starArray.length - 7]++; 
            }
            else if(gradesArray[i] >= 30){
                starArray[starArray.length - 8]++; 
            }
            else if(gradesArray[i] >= 20){
                starArray[starArray.length - 9]++; 
            }
            else if(gradesArray[i] >= 10){
                starArray[starArray.length - 10]++; 
            }
            else
                starArray[starArray.length - 11]++; 
        }
        
        for(int i = 0; i < starArray.length; i++){
            if(i < starArray.length-1){
                System.out.println((i*10) + "-" + ((i*10)+9) + ": " + starArray[i]);
            }
            else{
                System.out.println((i*10) + ": " + starArray[i]);
            }
        }
    
    }
    
}
