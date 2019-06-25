/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg5.gün;

import java.util.Scanner;

/**
 *
 * @author AYBU
 */
public class Lesson2Exercise2 {
    
    //##########################################################################
    //                    EXERCISE - 2
    // 14 kilograma kadar kilosu 2.5TL 14 kilodan fazlası 1.25TL 
    //##########################################################################
    
    // This function calculates cost depends on mass
    public static double cost(int mass){
        
        double cost = 0;
        double less = 14 * 2.5;;
        double greather = (mass-14) * 1.25;
        
        return cost = less + greather;
        
    }
    
    // ------------------------- MAIN FUNCTION ------------------------------- 
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        int mass;
        double cost;
        
        System.out.print("Enter number of kilograms: ");
        mass = input.nextInt();
        
        cost = cost(mass);
        
        if(mass > 14){
            System.out.println("Cost: " + cost);
        }
        else{
            System.out.println("You can not buy less than 14 kilogram!");
        }
        
    }
    
}
