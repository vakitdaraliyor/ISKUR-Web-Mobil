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
public class Lesson4Alistirma2 {
    
    public static void main(String[] args) {
        //######################################################################
        //--------------------- ALIŞTIRMA - 2 ------------------------
        //######################################################################
        
        Scanner input = new Scanner(System.in);
        
        String name;
        int hour;
        double pay;
        double taxFederal;
        double taxState;
        double finalPay;
        
        System.out.print("Enter employee's name: ");
        name = input.next();
        System.out.print("Enter the number of worked in a week: ");
        hour = input.nextInt();
        System.out.print("Enter hourly pay rate: ");
        pay = input.nextDouble();
        System.out.print("Enter federal tax witholding rate: ");
        taxFederal = input.nextDouble();
        System.out.print("Enter state tax witholding rate: ");
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
        System.out.println("\tFederal witholding(" + taxFederal + "): " + federalWithold);
        System.out.println("\tState witholding(" + taxState + "): " + stateWithold);
        System.out.println("Net Pay: " + finalPay);
    }
}
