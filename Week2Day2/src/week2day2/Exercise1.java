/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2day2;

import java.awt.Rectangle;

/**
 *
 * @author AYBU
 */
public class Exercise1 {
    
    public static void main(String[] args) {
        
        Rect r = new Rect(5, 8);
        Circle c = new Circle(4);
        Square s = new Square(6);
        
        r.alan();
        r.cevre();
        c.alan();
        c.cevre();
        s.alan();
        s.cevre();
        
    }
    
}

class Shape {
    
    public void alan(){
        System.out.println("alansız");
    }
    
    public void cevre(){
        System.out.println("cevresiz");
    }

}

//##############################################################################
//                            RECTANGLE (class)
//##############################################################################

class Rect extends Shape { 
    private int a;
    private int b;

    public Rect(int a, int b) {
        this.a = a;
        this.b = b;
    }
    
    @Override
    public void cevre(){
        double result = a * b;
        System.out.println("Dikdortgen cevresi: " + result);
    }
    
    @Override
    public void alan(){
        double result = 2*(a + b);
        System.out.println("Dikdortgen alanı: " + result);
    }

    public int getA() {
        return a;
    }

    public void setA(int a) {
        this.a = a;
    }

    public int getB() {
        return b;
    }

    public void setB(int b) {
        this.b = b;
    }
    
    
}

//##############################################################################
//                            CIRCLE (class)
//##############################################################################

class Circle extends Shape {
    
    private int radius;
    
    public Circle(int radius){
        this.radius = radius;
    }
    
    @Override
    public void cevre(){
        double result = 2 * Math.PI * radius; 
        System.out.println("Çember cevresi: " + result);
    }
    
    @Override
    public void alan(){
        double result = Math.PI * Math.pow(radius, 2);
        System.out.println("Çember alanı: " + result);
    }

    public int getRadius() {
        return radius;
    }

    public void setRadius(int radius) {
        this.radius = radius;
    }
    
}

//##############################################################################
//                            SQUARE (class)
//##############################################################################

class Square extends Shape {
    
    private int side;

    public Square(int side) {
        this.side = side;
    }
    
    @Override
    public void cevre(){
        double result = 4 * side; 
        System.out.println("Kare cevresi: " + result);
    }
    
    @Override
    public void alan(){
        double result = side * side;
        System.out.println("Kare alanı: " + result);
    }

    public int getSide() {
        return side;
    }

    public void setSide(int side) {
        this.side = side;
    }
        
}
