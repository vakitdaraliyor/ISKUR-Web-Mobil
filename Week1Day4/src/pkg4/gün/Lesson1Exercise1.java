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
public class Lesson1Exercise1 {

    /**
     * @param args the command line arguments
     */
    //##########################################################################
    //                    EXERCISE - 1
    // Finding twins prime number.
    // Twins prime number => Ex: (3,5) (7,9) (17,19) 
    //##########################################################################
    
    // This method check number is prime or not
    public static boolean isPrime(int sayi) {
        
        int counter = 0;
        for (int j = 1; j <= sayi; j++) {
            if ((sayi % j) == 0) {
                counter++;
            }
        }

        if (counter == 2) {
            return true;
        }
        
        counter = 0;
        return false;
    }

    // ------------------------- MAIN FUNCTION ------------------------------- 
    public static void main(String[] args) {

        for (int i = 0; i < 1000; i++) {
            if((isPrime(i) == true) && (isPrime((i+2)) == true)){
                System.out.println(i + " and " + (i+2) + " are prime numbers.");
            }
        }
        
    }
    
}
