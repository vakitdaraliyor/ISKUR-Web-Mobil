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

//##############################################################################
//                          EXERCISE - 2 
// Calculating distance between two points.
//##############################################################################

public class MyPoint {
    
    private int x;
    private int y;

    public MyPoint() {
        this.x = 0;
        this.y = 0;
    }
    
    public MyPoint(int x, int y) {
        this.x = x;
        this.y = y;
    }
    
    public double distance(MyPoint point){
        if(this.x == point.getX() && this.y == point.getY()){
            return 0;
        }
        else{
            return Math.sqrt(Math.pow((this.x - point.getX()), 2) + Math.pow((this.y - point.getY()), 2));
        }
    }
    
    public double distance(int x, int y){
        if(this.x == x && this.y == y){
            return 0;
        }
        else{
            return Math.sqrt(Math.pow((this.x - x), 2) + Math.pow((this.y - y), 2));
        }
    }

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }  
    
}
