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
public class İkinciGün {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        //######################################################################
        //--------------------- KULLANICIDAN DEĞER ALMA ------------------------
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        int userInputInt;
        String userInputString;
        
        System.out.println("------ İlk program başlıyor...------");
        
        System.out.print("Enter a number(Ex:6): ");
        userInputInt = input.nextInt();
        System.out.print("Enter a string(Ex:omer): ");
        userInputString = input.next();
        
        System.out.println("Kullanıcının girdiği sayı: " + userInputInt);
        System.out.println("Kullanıcının girdiği kelime: " + userInputString);
        
        //######################################################################
        //--------- KULLANICI NEGATİF SAYI GİRDİĞİNDE DÖNGÜDEN ÇIK -----------
        //######################################################################
        
        System.out.println("------ İkinci program başlıyor... ------");
        System.out.println("Negatif sayı girilene kadar kullanıcıdan sayı ister...");
        while(userInputInt >= 0){
            System.out.print("Enter number: ");
            userInputInt = input.nextInt();
        }
        
        System.out.println("Program closed!");
        
        //######################################################################
        //--------------------- ALIŞTIRMA - 1 ------------------------
        //######################################################################
        
        double weight, initialTemp, finalTemp, result;
        
        System.out.print("Enter the amount of water in kilograms: ");
        weight = input.nextDouble();
        System.out.print("Enter the initial temperature: ");
        initialTemp = input.nextDouble();
        System.out.print("Enter the final temperature: ");
        finalTemp = input.nextDouble();
        
        result = weight * (finalTemp - initialTemp) * 4184;
        
        System.out.println("The energy needed is: " + result);
        
        //######################################################################
        //--------------------- ALIŞTIRMA - 2 ------------------------
        //######################################################################
        
        String name;
        int hour;
        double pay;
        double taxFederal;
        double taxState;
        double finalPay;
        
        System.out.print("Enter employee's name(Ex:Smith): ");
        name = input.next();
        System.out.print("Enter the number of worked in a week(Ex:10): ");
        hour = input.nextInt();
        System.out.print("Enter hourly pay rate(Ex:6,75): ");
        pay = input.nextDouble();
        System.out.print("Enter federal tax witholding rate(Ex:0,20): ");
        taxFederal = input.nextDouble();
        System.out.print("Enter state tax witholding rate(Ex:0,09): ");
        taxState = input.nextDouble();
        
        double grossPay = hour*pay;
        double federalWithold = grossPay*taxFederal;
        double stateWithold = grossPay*taxState;
           
        finalPay = grossPay - federalWithold - stateWithold;
        
        System.out.println("Employee name: " + name);
        System.out.println("Hours worked: " + hour);
        System.out.println("Pay Rate: " + pay);
        System.out.println("Gross pay: " + grossPay);
        System.out.println("Deduction: ");
        System.out.println("\tFederal witholding(" + taxFederal + "): " + federalWithold + "(expected:13.5)");
        System.out.println("\tState witholding(" + taxState + "): " + stateWithold + "(expected: 6.075)");
        System.out.println("Net Pay(expected:47.925): " + finalPay);
        
        //######################################################################
        //--------------------- ALIŞTIRMA - 2 ------------------------
        //######################################################################
        
        double fahrenheitTemp;
        double windSpeed;
        double windIndex;
        
        System.out.print("Enter the temperature in Fahrenheit(Ex:5,3): ");
        fahrenheitTemp = input.nextDouble();
        System.out.print("Enter the wind speed miles per hour(Ex:6): ");
        windSpeed = input.nextDouble();
        
        if(windSpeed > 2){
            if((fahrenheitTemp > -58) && (fahrenheitTemp < 41)){
                windIndex = 35.74 + (0.6215*fahrenheitTemp) - (35.75*Math.pow(windSpeed, 0.16)) + (0.4275*fahrenheitTemp*Math.pow(windSpeed, 0.16));
                System.out.println("The wind chill index is(expected:-5.567068): " + windIndex);
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
