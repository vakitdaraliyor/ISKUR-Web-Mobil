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
public class Purchase {
    
    private String customerId;
    private String productId;
    private double amountByCustomer;

    public Purchase() {}
    
    public Purchase(String customerId, String productId, double amountByCustomer) {
        this.customerId = customerId;
        this.productId = productId;
        this.amountByCustomer = amountByCustomer;
    }

    /**
     * @return the customerId
     */
    public String getCustomerId() {
        return customerId;
    }

    /**
     * @param customerId the customerId to set
     */
    public void setCustomerId(String customerId) {
        this.customerId = customerId;
    }

    /**
     * @return the productId
     */
    public String getProductId() {
        return productId;
    }

    /**
     * @param productId the productId to set
     */
    public void setProductId(String productId) {
        this.productId = productId;
    }

    /**
     * @return the amountByCustomer
     */
    public double getAmountByCustomer() {
        return amountByCustomer;
    }

    /**
     * @param amountByCustomer the amountByCustomer to set
     */
    public void setAmountByCustomer(double amountByCustomer) {
        this.amountByCustomer = amountByCustomer;
    }
    
    

}
