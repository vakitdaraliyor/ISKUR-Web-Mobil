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
public class MyInteger {
    
    private int x;
    
    public MyInteger(int x){
        this.x = x; 
    }
    
    public boolean isOdd(){
        if((this.x%2) != 0){
            return true;
        }
        else{
            return false;
        }
    }
    
    public boolean isEven(){
        if((this.x%2) == 0){
            return true;
        }
        else{
            return false;
        }
    }
    
    public boolean isPrime(){
        int counter = 0;
        for(int i = 1; i <= this.x; i++){
            if((this.x%i) == 0){
                counter++;
            }
        }
        if(counter == 2){
            return true;
        }
        else{
            return false;
        }
    }
    
//##############################################################################    
// static methods take parameter as an integer (int x)
//############################################################################## 
    
    public static boolean isOdd(int x){
        if((x%2) != 0){
            return true;
        }
        else{
            return false;
        }
    }
    
    public static boolean isEven(int x){
        if((x%2) == 0){
            return true;
        }
        else{
            return false;
        }
    }
    
    public static boolean isPrime(int x){
        int counter = 0;
        for(int i = 1; i <= x; i++){
            if((x%i) == 0){
                counter++;
            }
        }
        if(counter == 2){
            return true;
        }
        else{
            return false;
        }
    }
    
//############################################################################## 
// static methods take parameters as an object (MyInteger number)
//############################################################################## 
    
    public static boolean isOdd(MyInteger number){
        if((number.getX()%2) != 0){
            return true;
        }
        else{
            return false;
        }
    }
    
    public static boolean isEven(MyInteger number){
        if((number.getX()%2) == 0){
            return true;
        }
        else{
            return false;
        }
    }
    
    public static boolean isPrime(MyInteger number){
        int counter = 0;
        for(int i = 1; i <= number.getX(); i++){
            if((number.getX()%i) == 0){
                counter++;
            }
        }
        if(counter == 2){
            return true;
        }
        else{
            return false;
        }
    }
    
//############################################################################## 
// equals methods (we can not static)
//############################################################################## 
    
    public boolean equals(int x){
        if(this.x == x){
            return true;
        }
        else{
            return false;
        }
    }

    public boolean equals(MyInteger integer){
        if(this.x == integer.getX()){
            return true;
        }
        else{
            return false;
        }
    }

//############################################################################## 
// char array to int array
//############################################################################## 
    
    public int[] parseInt(char[] charArray){
        int[] intArray = new int[charArray.length];
        for(int i = 0; i < intArray.length; i++){
            intArray[i] = Character.getNumericValue(charArray[i]);
        }
        return intArray;
    }

//############################################################################## 
// string to int array
//############################################################################## 
    
    public int[] parseInt(String string){
        
        String stringTrue = string.replaceAll("\\s+", "");
        int[] intArray = new int[stringTrue.length()];
        
        for(int i = 0; i < intArray.length; i++){
            intArray[i] = Integer.valueOf(stringTrue.charAt(i)+"");
        }
        
        return intArray;
    }

//############################################################################## 
// setters and getters
//##############################################################################
    
    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }
    
}
