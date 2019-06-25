/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bank;

import java.util.ArrayList;

/**
 *
 * @author AYBU
 */
public class Operations {
    
    private ArrayList<Person> personsList;
    
    // -------------------------------------------------------------------------
    //                      Constructor
    // -------------------------------------------------------------------------
    
    public Operations(){
        personsList = new ArrayList<>();
    }
    
    // -------------------------------------------------------------------------
    //                      Methods
    // -------------------------------------------------------------------------
    
    public void addPerson(Person p){
        personsList.add(p);
    }
    
    public void getCustomerBigger(int salary){
        System.out.println("<---- Greater than " + salary + "TL salary ---->");
        for(Person p : personsList){
            if(p.getSalary() > salary){
                System.out.println(p.toString());
            }
        }
        System.out.println();
    }
    
    public void getJob(String jobName){
        System.out.println("<---- Result for " + jobName + " job ---->");
        for(Person p : personsList){
            if(p.getJob().equalsIgnoreCase(jobName)){
                System.out.println(p.toString());
            }
        }
        System.out.println();
    }
    
    public void getAge(int age){
        System.out.println("<---- Equals and greather than " + age + " (age) ---->");
        for(Person p : personsList){
            if(p.getAge() >= age){
                System.out.println(p.toString());
            }
        }
        System.out.println();
    }
    
    public void isEligible(int salary){
        System.out.println("<---- Eligible Persons for " + salary + "TL credit---->");
        for(Person p : personsList){
            if(p.getSalary()*0.7 > salary){
                System.out.println(p.toString());
            }
        }
        System.out.println();
    }
    
    public void getAllPersons(){
        System.out.println("<---- All persons ---->");
        for(Person p : personsList){
            System.out.println(p.toString());
        }
        System.out.println();
    }
    
    // -------------------------------------------------------------------------
    //                      setters and getters
    // -------------------------------------------------------------------------

    /**
     * @return the personsList
     */
    public ArrayList<Person> getPersonsList() {
        return personsList;
    }

    /**
     * @param personsList the personsList to set
     */
    public void setPersonsList(ArrayList<Person> personsList) {
        this.personsList = personsList;
    }
        
}
