/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lesson2Exercise2;

/**
 *
 * @author AYBU
 */
public class Test {
    
    public static void main(String[] args) {
        
        MyPoint p1 = new MyPoint();
        MyPoint p2 = new MyPoint(4,2);
        
        System.out.println("Result: " + p1.distance(p2));
        System.out.println("Result: " + p1.distance(3, 4));
        System.out.println("Result: " + p2.distance(9, 14));
        System.out.println("Result: " + p1.distance(p1));
        System.out.println("Result: " + p2.distance(4, 2));
        
    }
    
}
