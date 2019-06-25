/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bank;

/**
 *
 * @author AYBU
 */
public class Person {
    
    private String firstname;
    private String lastname;
    private String street;
    private String state;
    private String city;
    private String phoneNumber;
    private int salary;
    private String job;
    private int age;
    
    // -------------------------------------------------------------------------
    //                      Constructor
    // -------------------------------------------------------------------------
    
    public Person(String line){
        
        setFirstname(line.split(" ")[0]);
        setLastname(line.split(" ")[1]);
        setStreet(line.split(" ")[2].split("-")[0]);
        setState(line.split(" ")[2].split("-")[1]);
        setCity(line.split(" ")[2].split("-")[2]);
        setPhoneNumber(line.split(" ")[3]);
        setSalary(Integer.parseInt(line.split(" ")[4]));
        setJob(line.split(" ")[5]);
        setAge(Integer.parseInt(line.split(" ")[6]));
    }

    @Override
    public String toString() {
        return "Person{" + "firstname=" + firstname + ", lastname=" + lastname + ", street=" + street + ", state=" + state + ", city=" + city + ", phoneNumber=" + phoneNumber + ", salary=" + salary + "TL" + ", job=" + job + ", age=" + age + '}';
    }

    // -------------------------------------------------------------------------
    //                      setters and getters
    // -------------------------------------------------------------------------

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
     * @return the salary
     */
    public int getSalary() {
        return salary;
    }

    /**
     * @param salary the salary to set
     */
    public void setSalary(int salary) {
        this.salary = salary;
    }

    /**
     * @return the job
     */
    public String getJob() {
        return job;
    }

    /**
     * @param job the job to set
     */
    public void setJob(String job) {
        this.job = job;
    }

    /**
     * @return the age
     */
    public int getAge() {
        return age;
    }

    /**
     * @param age the age to set
     */
    public void setAge(int age) {
        this.age = age;
    }
    
}
