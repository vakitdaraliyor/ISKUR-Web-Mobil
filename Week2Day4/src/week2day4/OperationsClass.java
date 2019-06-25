/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2day4;

import java.util.ArrayList;

/**
 *
 * @author AYBU
 */
public class OperationsClass {
    
    private ArrayList<Person> personsList;

    // -------------------------------------------------------------------------
    //                      Constructor (no argument)
    // -------------------------------------------------------------------------
    
    public OperationsClass() {
        personsList = new ArrayList<>();
    }
    
    // -------------------------------------------------------------------------
    //                      Methods
    // -------------------------------------------------------------------------
    public void searchByName(String name){
        for(Person p : personsList){
            if(p.getFirstname().equalsIgnoreCase(name.trim())){
                System.out.println(p.toString());
            }
        }
    }
    
    public void searchById(String id){
        for(Person p : personsList){
            if(p.getId().equals(id)){
                System.out.println(p.toString());
            }
        }
    }
    
    public void searchByCity(String city){
        for(Person p : personsList){
            if(p.getCity().equalsIgnoreCase(city)){
                System.out.println(p.toString());
            }
        }
    }
    
    public boolean isUnique(String id){
        for (Person p : personsList) {
            if(p.getId().equals(id)){
                return false;
            }
        }
        return true;
    }
    
    public void addPerson(Person p){
        if(isUnique(p.getId())){
            personsList.add(p);
        }
        else{
            System.out.println("Failed to add user.Id is not unique!\n" + "***" + p.toString());
        }
    }
    
    public void getList(){
        System.out.println("<---- Persons List ---->");
        for(Person p: personsList){
            System.out.println(p.toString());
        }
    }

    // -------------------------------------------------------------------------
    //                      setters and getters
    // -------------------------------------------------------------------------
    
    /**
     * @return the persons
     */
    public ArrayList<Person> getPersonsList() {
        return personsList;
    }

    /**
     * @param persons the persons to set
     */
    public void setPersonsList(ArrayList<Person> personsList) {
        this.personsList = personsList;
    }
        
}
