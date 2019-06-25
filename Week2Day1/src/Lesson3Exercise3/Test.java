/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lesson3Exercise3;

/**
 *
 * @author AYBU
 */
public class Test {
    
    public static void main(String[] args) {
        
        MyInteger i1 = new MyInteger(5);
        MyInteger i2 = new MyInteger(4);
        
        char[] charArray = {'4', '1', '6', '2', '3', '9'}; 
        int[] intArray = i1.parseInt(charArray);
        
        String stringNum = "123 4567 890";
        int[] intArray2 = i1.parseInt(stringNum);
        
        System.out.println(i1.getX() + " is even?: " + i1.isEven());
        System.out.println(i1.getX() + " is odd?: " + i1.isOdd());
        System.out.println(i1.getX() + " is prime?: " + i1.isPrime() + "\n");
        
        System.out.println(i2.getX() + " is even?: " + i2.isEven());
        System.out.println(i2.getX() + " is odd: " + i2.isOdd());
        System.out.println(i2.getX() + " is prime?: " + i2.isPrime() + "\n");
        
        System.out.println("(static method) 4 is even?: " + MyInteger.isEven(4));
        System.out.println("(static method) 4 is odd?: " + MyInteger.isOdd(4));
        System.out.println("(static method) 4 is prime?: " + MyInteger.isPrime(4) + "\n");
        
        System.out.println("Equals: " + i1.equals(5));
        System.out.println("Equals: " + i1.equals(i2) + "\n");
        
        System.out.println("Char to int array convertion: ");
        for(int i = 0; i < intArray.length; i++){
            System.out.print(intArray[i] + " ");
        }
        
        System.out.println("\nString to int array convertion: ");
        for(int i = 0; i < intArray2.length; i++){
            System.out.print(intArray2[i] + " ");
        }
    }
    
}
