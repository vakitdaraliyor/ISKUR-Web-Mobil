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
public class Lesson5Alistirma3 {
    
    public static void main(String[] args){
        
        //######################################################################
        //--------------------- ALIŞTIRMA - 3 ------------------------
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        
        double fahrenheitTemp;
        double windSpeed;
        double windIndex;
        
        System.out.print("Enter the temperature in Fahrenheit: ");
        fahrenheitTemp = input.nextDouble();
        System.out.print("Enter the wind speed miles per hour: ");
        windSpeed = input.nextDouble();
        
        if(windSpeed > 2){
            if((fahrenheitTemp > -58) && (fahrenheitTemp < 41)){
                windIndex = 35.74 + (0.6215*fahrenheitTemp) - (35.75*Math.pow(windSpeed, 0.16)) + (0.4275*fahrenheitTemp*Math.pow(windSpeed, 0.16));
                System.out.println("The wind chill index is: " + windIndex);
            }
            else{
                System.out.println("Temperature should between -58 and 21 Fahrenheit!");
            }
        }
        else{
            System.out.println("Wind speed can not less than 2mph!");
        }
        
    }
    
}
