/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package test;

import operations.CustomerOperations;
import java.util.Scanner;
import models.Customer;
import operations.ProductOperations;
import operations.PurchaseOperations;

/**
 *
 * @author AYBU
 */
public class Test {
    
    public static void main(String[] args) {
        
        menu();
        
    }

    public static void menu() {
        Scanner input = new Scanner(System.in);
        
        CustomerOperations co = new CustomerOperations();
        ProductOperations po = new ProductOperations();
        PurchaseOperations purop = new PurchaseOperations();
        
        int choice = 0;
        
        while(choice != 16){
            System.out.println("<---- Enter your choice ---->");
            System.out.println("1)Read customer from file");
            System.out.println("2)Add customer");
            System.out.println("3)Delete customer");
            System.out.println("4)Update customer");
            System.out.println("5)Write customers to file");
            System.out.println("6)Read product from file");
            System.out.println("7)Add product");
            System.out.println("8)Delete product");
            System.out.println("9)Update product");
            System.out.println("10)Purchase");
            System.out.println("11)Write product to file");
            System.out.println("12)List products");
            System.out.println("13)List customers");
            System.out.println("14)Search for a product");
            System.out.println("15)Purchase list");
            System.out.println("16)Exit");
            choice = input.nextInt();
            
            switch(choice){
                case 1:
                    co.readFile();
                    break;
                case 2:
                    co.addCustomer();
                    break;
                case 3:
                    co.deleteCustomer();
                    break;
                case 4:
                    co.updateCustomer();
                    break;
                case 5:
                    co.writeFile();
                    break;
                case 6:
                    co.readFile();
                    break;
                case 7:
                    po.addProduct();
                    break;
                case 8:
                    po.deleteProduct();
                    break;
                case 9:
                    po.updateProduct();
                    break;
                case 10:
                    po.purchase();
                    break;
                case 11:
                    po.writeFile();
                    break;
                case 12:
                    po.getAllProducts();
                    break;
                case 13:
                    co.getAllCustomers();
                    break;
                case 14:
                    po.searchProduct();
                    break;
                case 15:
                    purop.getListOfPurchases();
                    break;
                case 16:
                    break;
                default:
                    break;
            }
            
        }
    }
    
}
