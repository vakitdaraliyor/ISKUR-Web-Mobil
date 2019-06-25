/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package operations;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Scanner;
import models.Customer;
import models.Product;
import models.Purchase;

/**
 *
 * @author AYBU
 */
public class ProductOperations {
    
    private ArrayList<Product> productList;
    private PurchaseOperations purop;
    
    public ProductOperations(){
        productList = new ArrayList<>();
        purop = new PurchaseOperations();
    }
    
    Scanner input = new Scanner(System.in);
    public boolean isUnique(String id){
        for(Product p : productList){
            if(p.getId().equals(p)){
                return false;
            }
        }
        return true;
    }
    
    public boolean isExist(String id){
        for(Product p : productList){
            if(p.getId().equals(p)){
                return true;
            }
        }
        return false;
    }
    
    public Product getProductById(String id){
        Product product = new Product();
        for(Product p : productList){
            if(p.getId().equals(id)){
                product = p;
            }
        }
        return product;
    }
    
    public void searchProduct(){
        
        System.out.print("Enter id you search for: ");
        String searchId = input.next();
        Product p = getProductById(searchId);
        System.out.println("ProductID: " + p.getId() + 
                           "\n\tProduct name: " + p.getProductName() +
                           "\n\tAmount: " + p.getAmount() + 
                           "\n\tPrice: " + p.getPrice()+"\n");
        
    }
    
    public void addProduct(){
        
        System.out.println("<---- Add product operation ---->");
        System.out.print("Enter product id: ");
        String productId = input.next();
        System.out.print("Enter product name: ");
        String productName = input.next();
        System.out.print("Enter amount of product: ");
        int amount = input.nextInt();
        System.out.print("Enter price of product: ");
        double price = input.nextDouble();
        
        
        if(isUnique(productId)){
            Product p = new Product(productId, productName, amount, price);
            productList.add(p);
            System.out.println("Product added!");
        }
        else{
            System.out.println("Failed to add product.Id is not unique!\n");
        }
    }
    
    public void deleteProduct(){
        Scanner input = new Scanner(System.in);
        System.out.println("<---- Delete customer operation ---->");
        System.out.print("Enter the id you want to delete: ");
        String deleteId = input.next();
        
        if(isExist(deleteId)){
            Product p = getProductById(deleteId);
            productList.remove(p);
            System.out.println("Product deleted!");
        }
        else{
            System.out.println("Product is not exist!");
        }
    }
    
    public void updateProduct(){
        Scanner input = new Scanner(System.in);
        System.out.println("<---- Update customer operation ---->");
        System.out.print("Enter the id you want to update: ");
        String updateId = input.next();
        
        if(isExist(updateId)){
            Product p = getProductById(updateId);

            System.out.print("Enter new product name: ");
            String newName = input.next();
            p.setProductName(newName);
            System.out.print("Enter new amount: ");
            int newAmount = input.nextInt();
            p.setAmount(newAmount);
            System.out.print("Enter new price: ");
            double newPrice = input.nextDouble();
            p.setPrice(newPrice);
            System.out.println("Product updated!");
        }
    }
    
    public void getAllProducts(){
        System.out.println("<---- Products list ---->");
        for(Product p : productList){
            System.out.println(p.toString());
        }
        System.out.println();
    }
    
    public void purchase(){
        
        System.out.print("Enter customer id: ");
        String customerId = input.next();
        System.out.print("Enter product id: ");
        String productId = input.next();
        System.out.print("Enter amount to make a purchase: ");
        int amountOfPurchase = input.nextInt();
        
        for(Product p : productList){
            if(p.getId().equals(productId)){
                if(p.getAmount() >= amountOfPurchase){
                    Purchase pur = new Purchase(customerId, productId, amountOfPurchase);
                    p.setAmount(p.getAmount()-amountOfPurchase);
                    purop.getPurchaseList().add(pur);
                }
            }
        }
    }
    
    public void writeFile(){
        FileWriter fw;    
        try {
            fw = new FileWriter("C:\\Users\\AYBU\\Desktop\\Products.txt");
            String newLine = System.getProperty("line.separator");
            for(Product p : productList){
                fw.write(p.toString()+ newLine);
            }
            fw.close(); 
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        System.out.println("All products wrote into Customers.txt file\n");
    }
    
    public void readFile(){
        System.out.println("<---- Read all products details from file ---->");
        try {
            BufferedReader br = new BufferedReader(new FileReader(new File("C:\\Users\\AYBU\\Desktop\\Products.txt")));
            
            String line;
            
            while((line = br.readLine()) != null){
                System.out.println(line);
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    } 

    /**
     * @return the productList
     */
    public ArrayList<Product> getProductList() {
        return productList;
    }

    /**
     * @param productList the productList to set
     */
    public void setProductList(ArrayList<Product> productList) {
        this.productList = productList;
    }
    
    
            
}
