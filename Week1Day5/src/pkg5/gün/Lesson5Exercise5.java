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
public class Lesson5Exercise5 {
    
    //##########################################################################
    //                    EXERCISE - 5
    // Matrice check
    //##########################################################################
    
    // This function fill matrices
    public static int[][] fillMatrices(int dim1, int dim2){
        
        Scanner in = new Scanner(System.in);
        
        int[][] matrise = new int[dim1][dim2];
        int index = 1;
        
        for(int i = 0; i < dim1; i++){
            for(int j = 0; j < dim2; j++){
                System.out.print("Enter " + (index) + ". element of matrise: ");
                matrise[i][j] = in.nextInt();
                index++;
            }
        }
        
        return matrise;
    }
    
    // This function compare matrices
    public static void compareMatrise(int[][] matrise1, int matrise2[][]){
        
        for(int i = 0; i < matrise1.length; i++){
            for(int j = 0; j < matrise1.length; j++){
                for( int k = 0; k < matrise2.length; k++){
                    for(int m = 0; m < matrise2.length; m++){
                        if(matrise1[i][j] == matrise2[k][m]){
                            System.out.println(matrise2[k][m] + " at index " + k + ", " + m);
                        }
                    }
                }
            }
        }
        
    }
    
    // ------------------------- MAIN FUNCTION ------------------------------- 
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        
        int dim1;
        int dim2; 
        
        System.out.print("Please enter first dimension of matrise: ");
        dim1 = input.nextInt();
        System.out.print("Please enter second dimension of matrise: ");
        dim2 = input.nextInt();
        
        int[][] firstMatrise = new int[dim1][dim2];
        int[][] secondMatrise = new int[dim1][dim2];
        
        System.out.println("First Matrise filling start...");
        firstMatrise = fillMatrices(dim1, dim2);
        System.out.println("First matrise filled!");
        
        System.out.println("Second Matrise filling start...");
        secondMatrise = fillMatrices(dim1, dim2);
        System.out.println("Second matrise filled!");
        
        compareMatrise(firstMatrise, secondMatrise);
        
        System.out.println("<--- Matrises --->");
        System.out.println("<--- First matrise --->");
        
        for(int i = 0; i < dim1; i++){
            System.out.println();
            for(int j = 0; j < dim2; j++){
                System.out.print(firstMatrise[i][j] + " ");
            }
        }
        
        System.out.println();
        
        System.out.println("<--- Second matrise --->");
        for(int i = 0; i < dim1; i++){
            System.out.println();
            for(int j = 0; j < dim2; j++){
                System.out.print(secondMatrise[i][j] + " ");
            }
        }
        System.out.println();  
    }
    
}
