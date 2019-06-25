/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package object.giris;

/**
 *
 * @author AYBU
 */
public class Test {
    
    public static void main(String[] args) {
        
        ComplexNumber number1 = new ComplexNumber(3.4, 1.2);
        ComplexNumber number2 = new ComplexNumber(2.0, 3.5);
        
        ComplexNumber result1 = number1.add(number2);
        ComplexNumber result2 = number1.sub(number2);
        
        System.out.println("Result1: " + result1.getComplexNumber());
        System.out.println("Result2: " + result2.getComplexNumber());
        
    }
    
}
