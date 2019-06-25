/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg1.gün;

/**
 *
 * @author AYBU
 */
public class BirinciGün {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        int counter = 0;
        int numOfPrime = 0;
        
        for(int i = 0; i < 1000; i++){
            for(int j = 1; j <= i; j++){
                if((i%j)==0){
                    counter++;
                }
            }
            
            if(counter == 2){
                numOfPrime++;
                System.out.println(numOfPrime + ") " + i + " Prime number");               
            }
            counter = 0;
        }
        System.out.println("Total prime numbers: " + numOfPrime);
        
    }
    
    
}
