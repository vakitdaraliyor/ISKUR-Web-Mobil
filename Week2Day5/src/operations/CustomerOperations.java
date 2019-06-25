/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package operations;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import models.Customer;

/**
 *
 * @author AYBU
 */
public class CustomerOperations {
    
    private ArrayList<Customer> customerList= new ArrayList<Customer>();
    
    public CustomerOperations(){
        customerList = new ArrayList<>();
    }
    
    // -------------------------------------------------------------------------
    //                          Methods
    // -------------------------------------------------------------------------
    public Customer getCustomerById(String id){
        Customer customer = new Customer();
        for(Customer c : customerList){
            if(c.getId().equals(id)){
                customer = c;
            }
        }
        return customer;
    }
    
    public boolean isUnique(String id){
        for (Customer c : customerList) {
            if(c.getId().equals(id)){
                return false;
            }
        }
        return true;
    }
    
    public boolean isExist(String id){
        for(Customer c : customerList){
            if(c.getId().equals(id)){
                return true;
            }
        }
        return false;
    }
    
    public void addCustomer(){
        Scanner input = new Scanner(System.in);
        System.out.println("<---- Add customer operation ---->");
        System.out.print("Enter customer id: ");
        String customerId = input.next();
        System.out.print("Enter customer name: ");
        String customerName = input.next();
        System.out.print("Enter customer address: ");
        String customerAddress = input.next();
        
        if(isUnique(customerId) && isExist(customerId) == false){
            Customer c = new Customer(customerId, customerName, customerAddress);
            customerList.add(c);
            System.out.println("Customer added!\n");
        }
        else{
            System.out.println("Failed to add user.Id is not unique!\n");
        }
    }
    
    public void deleteCustomer(){
        
        Scanner input = new Scanner(System.in);
        System.out.println("<---- Delete customer operation ---->");
        System.out.print("Enter the id you want to delete: ");
        String deleteId = input.next();
        
        if(isExist(deleteId)){
            Customer deletedCustomer = getCustomerById(deleteId);
            customerList.remove(deletedCustomer);
            System.out.println("Customer deleted!\n");
        }
        else{
            System.out.println(deleteId + " is not exist!\n");
        }
    }
    
    public void updateCustomer(){
        Scanner input = new Scanner(System.in);
        System.out.println("<---- Update customer operation ---->");
        System.out.print("Enter the id you want to update: ");
        String updateId = input.next();
        
        if(isExist(updateId)){
            Customer updateCustomer = getCustomerById(updateId);
            String newAddress;
            String newName;

            System.out.print("Enter new name: ");
            newName = input.next();
            updateCustomer.setCustomerName(newName);
            System.out.print("Enter new address: ");
            newAddress = input.next();
            updateCustomer.setAddress(newAddress);
            System.out.println("Customer updated!\n");
        }
        else{
            System.out.println("Customer is not exist!\n");
        }
    }
    
    public void getAllCustomers(){
        System.out.println("<---- Customer list ---->");
        for(Customer c : customerList){
            System.out.println(c.toString());
        }
        System.out.println();
    }
    
    public void writeFile(){
        FileWriter fw;    
        try {
            fw = new FileWriter("C:\\Users\\AYBU\\Desktop\\Customers.txt");
            String newLine = System.getProperty("line.separator");
            for(Customer c : customerList){
                fw.write(c.toString()+ newLine);
            }
            fw.close(); 
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        System.out.println("All customers wrote into Customers.txt file\n");
    }
    
    public void readFile(){
        System.out.println("<---- Read all customers details from file ---->");
        try {
            BufferedReader br = new BufferedReader(new FileReader(new File("C:\\Users\\AYBU\\Desktop\\Customers.txt")));
            
            String line;
            
            while((line = br.readLine()) != null){
                System.out.println(line);
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        System.out.println();
    }
    

    /**
     * @return the customerList
     */
    public ArrayList<Customer> getCustomerList() {
        return customerList;
    }

    /**
     * @param customerList the customerList to set
     */
    public void setCustomerList(ArrayList<Customer> customerList) {
        this.customerList = customerList;
    }
    
    
    
}
