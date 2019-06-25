/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2day4;

/**
 *
 * @author AYBU
 */
public class Person {

    private String id;
    private String firstname;
    private String lastname;
    private String address;
    private String street;
    private String state;
    private String city;
    private String phoneNumber;
    
    // -------------------------------------------------------------------------
    //                      Constructor
    // -------------------------------------------------------------------------

    public Person(String line) {
        
        setFirstname(line.split(" ")[0]);
        setLastname(line.split(" ")[1]);
        setAddress(line.split(" ")[2]);
        setStreet(line.split(" ")[2].split("-")[0]);
        setState(line.split(" ")[2].split("-")[1]);
        setCity(line.split(" ")[2].split("-")[2]);
        setId(line.split(" ")[3]);
        setPhoneNumber(line.split(" ")[4]);
    }

    @Override
    public String toString() {
        return "Person{" + "id=" + id + ", firstname=" + firstname + ", lastname=" + lastname + ", address=" + address + ", phoneNumber=" + phoneNumber + "\n" 
             + "Address=> " + " street=" + street + ", state=" + state + ", city=" + city +'}'+"\n";
    }
    
    // -------------------------------------------------------------------------
    //                      setters and getters
    // -------------------------------------------------------------------------
    
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
     * @return the firstname
     */
    public String getFirstname() {
        return firstname;
    }

    /**
     * @param firstname the firstname to set
     */
    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    /**
     * @return the lastname
     */
    public String getLastname() {
        return lastname;
    }

    /**
     * @param lastname the lastname to set
     */
    public void setLastname(String lastname) {
        this.lastname = lastname;
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

    /**
     * @return the phoneNumber
     */
    public String getPhoneNumber() {
        return phoneNumber;
    }

    /**
     * @param phoneNumber the phoneNumber to set
     */
    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    /**
     * @return the street
     */
    public String getStreet() {
        return street;
    }

    /**
     * @param street the street to set
     */
    public void setStreet(String street) {
        this.street = street;
    }

    /**
     * @return the state
     */
    public String getState() {
        return state;
    }

    /**
     * @param state the state to set
     */
    public void setState(String state) {
        this.state = state;
    }

    /**
     * @return the city
     */
    public String getCity() {
        return city;
    }

    /**
     * @param city the city to set
     */
    public void setCity(String city) {
        this.city = city;
    }
    
}
