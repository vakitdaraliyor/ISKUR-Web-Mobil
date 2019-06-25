/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2day2;

/**
 *
 * @author AYBU
 */
public class Week2Day2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Animals a1 = new Bird();
        Animals a2 = new Dog();
        Animals a3 = new Fish();
        
        Bird b = new Bird();
        Dog d = new Dog();
        Fish f = new Fish();
        
        a1.voice();
        a2.voice();
        a3.voice();
        b.voice();
        d.voice();  
        f.voice();
        
    }
    
}

class Animals{
    
    private String name;
    private String color;

    public Animals(){}
    
    public Animals(String name, String color) {
        this.name = name;
        this.color = color;
    }

    public void voice(){
        System.out.println("Slience");
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }   
        
}
    
class Bird extends Animals{
    
    private int numOfLeg;

    public Bird() {}
    
    public Bird(int numOfLeg, String name, String color) {
        super(name, color);
        this.numOfLeg = numOfLeg;
    }

    public int getNumOfLeg() {
        return numOfLeg;
    }

    public void setNumOfLeg(int numOfLeg) {
        this.numOfLeg = numOfLeg;
    }
    
    @Override
    public void voice(){
        System.out.println("Bid: Cik Cik");
    }
}
    
class Dog extends Animals{

    public Dog(){}
    
    public Dog(String name, String color) {
        super(name, color);
    }
    
    @Override
    public void voice(){
        System.out.println("Dog: Hav hav");
    }
}

class Fish extends Animals{
    
    public Fish(){}
    
    public Fish(String name, String color) {
        super(name, color);
    }
    
}
