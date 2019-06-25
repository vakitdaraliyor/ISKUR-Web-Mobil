/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg2.gün;

/**
 *
 * @author AYBU
 */
public class Lesson6IlkFonksiyon {
    
    //##########################################################################
    //--------------------------- FONKSİYONLAR --------------------------------
    //##########################################################################
    
    public static void hello(){
        System.out.println("Merhaba Fonksiyon");
    }
    
    public static int sum(int x1, int x2){
       int result;
       result = x1 + x2;
       return result;
    }
    
    public static int pow(int x1, int x2){
        int begin = 1;
        int result = 1;
        while(begin <= x2){
            result = result*x1;
            begin++;
        }
        return result;
    }
    
    public static int factorial(int x1){
        int begin = 1;
        int result = 1;
        while(begin <= x1){
            result = result*begin;
            begin++;
        }
        return result;
    }
    
    //---------------------- MAIN FONKSİYON --------------------------------
    
    public static void main(String[] args){
        hello();
        
        int firstNumber = 3;
        int secondNumber = 5;
        int result = sum(firstNumber, secondNumber);
        int result2 = sum(10,20);
        System.out.println("Sayıların toplamı: " + result);
        System.out.println("Sayıların toplamı: " + result2);
        System.out.println("Sayıların toplamı: " + sum(10,5));
        
        int result3 = pow(firstNumber, secondNumber);
        System.out.println("Pow fonksiyonu sonucu: " + result3);
        
        int result4 = factorial(5);
        System.out.println("Faktöriyel fonksiyonu sonucu: " + result4);
    }
    
}
