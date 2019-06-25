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
public class Lesson7FonksiyonAlistirma1 {
    
    //  Gerekli eneriyi hesaplayan fonksiyon
    //  enerjı = kutle x (son sicaklik - ilk sicaklik) x 4184
    public static double energyCalculate(double mass, double initialTemp, double finalTemp){
        double result = mass*(finalTemp-initialTemp)*4184;
        return result;
    } 
    
    //------------------------- MAIN FONKSIYON ---------------------------------
    
    public static void main(String[] args){
        
        double mass = 55.5;
        double initialTemp = 3.5;
        double finalTemp = 10.5;
        
        double energy = energyCalculate(mass, initialTemp, finalTemp);
        System.out.println("Energy: " + energy);
        
    }
    
}
