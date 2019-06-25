/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package operations;

import java.util.ArrayList;
import java.util.Scanner;
import models.Customer;
import models.Product;
import models.Purchase;
import operations.CustomerOperations;
import operations.ProductOperations;

/**
 *
 * @author AYBU
 */
public class PurchaseOperations {
    
    private ArrayList<Purchase> purchaseList;
    private CustomerOperations customer;
    private ProductOperations product;
    
    public PurchaseOperations(){
        purchaseList = new ArrayList<>();
        //customer = new CustomerOperations();
        //product = new ProductOperations();
    }
    
    Scanner input = new Scanner(System.in);
    
    public void getListOfPurchases(){
        for(Purchase pur : purchaseList){
            System.out.println(pur.toString());
        }
    }
    
    /*public void purchase(){
        
        System.out.print("Enter customer id: ");
        String customerId = input.next();
        System.out.print("Enter product id: ");
        String productId = input.next();
        System.out.print("Enter amount to make a purchase: ");
        int amountOfPurchase = input.nextInt();
        
        for(Product p : product.getProductList()){
            if(p.getId().equals(productId)){
                if(p.getAmount() >= amountOfPurchase){
                    Purchase pur = new Purchase(customerId, productId, amountOfPurchase);
                    p.setAmount(p.getAmount()-amountOfPurchase);
                    purchaseList.add(pur);
                }
            }
        }
    }*/
    
    /**
     * @return the purchaseList
     */
    public ArrayList<Purchase> getPurchaseList() {
        return purchaseList;
    }

    /**
     * @param purchaseList the purchaseList to set
     */
    public void setPurchaseList(ArrayList<Purchase> purchaseList) {
        this.purchaseList = purchaseList;
    }

    /**
     * @return the customer
     */
    public CustomerOperations getCustomer() {
        return customer;
    }

    /**
     * @param customer the customer to set
     */
    public void setCustomer(CustomerOperations customer) {
        this.customer = customer;
    }

    /**
     * @return the product
     */
    public ProductOperations getProduct() {
        return product;
    }

    /**
     * @param product the product to set
     */
    public void setProduct(ProductOperations product) {
        this.product = product;
    }
    
}
