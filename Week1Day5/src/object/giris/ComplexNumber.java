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
public class ComplexNumber {
    
    private double reel;
    private double imaginery;
   
    // Constructure
    public ComplexNumber(double reel, double imaginery){
        this.reel = reel;
        this.imaginery = imaginery;
    }

    public ComplexNumber add(ComplexNumber num){

        double newReel = this.reel + num.getReel();
        double newImaginery = this.imaginery + num.getImaginery();

        return new ComplexNumber(newReel, newImaginery);

    }

    public ComplexNumber sub(ComplexNumber num){

        double newReel = this.reel - num.getReel();
        double newImaginery = this.imaginery - num.getImaginery();

        return new ComplexNumber(newReel, newImaginery);

    }

    public String getComplexNumber(){

        String s="";

        if(this.imaginery > 0){
            s = this.reel + "+" + this.imaginery;
        }
        else{
            s = this.reel + "" + this.imaginery;
        }

        return s;

    }

    public double getReel() {
        return reel;
    }

    public void setReel(double reel) {
        this.reel = reel;
    }

    public double getImaginery() {
        return imaginery;
    }

    public void setImaginery(double imaginery) {
        this.imaginery = imaginery;
    }
   
}
