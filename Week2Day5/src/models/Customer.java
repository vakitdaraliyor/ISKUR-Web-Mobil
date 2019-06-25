/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package models;

/**
 *
 * @author AYBU
 */
public class Customer {

    private String id;
    private String customerName;
    private String address;

    public Customer() {}
    
    public Customer(String id, String customerName, String address) {
        this.id = id;
        this.customerName = customerName;
        this.address = address;
    }

    @Override
    public String toString() {
        return "Customer{" + "id=" + id + ", customerName=" + customerName + ", address=" + address + '}';
    }
    
    

    /**
     * @return the id
     */
    public String getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(String id) {
        this.id = id;
    }

    /**
     * @return the customerName
     */
    public String getCustomerName() {
        return customerName;
    }

    /**
     * @param customerName the customerName to set
     */
    public void setCustomerName(String customerName) {
        this.customerName = customerName;
    }

    /**
     * @return the address
     */
    public String getAddress() {
        return address;
    }

    /**
     * @param address the address to set
     */
    public void setAddress(String address) {
        this.address = address;
    }
    
    
    
}
