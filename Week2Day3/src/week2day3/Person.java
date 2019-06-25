/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2day3;

/**
 *
 * @author AYBU
 */
public class Person {
    
    private String firstname;
    private String lastname;
    private int age;
    private String hobby;

// -----------------------------------------------------------------------------
// Constructors
// Person(line)
// Person(String firstname, String lastname, int age, String hobby)
// -----------------------------------------------------------------------------
    
    public Person(String line){
        
        String[] splitted = line.split(" ");
        
        setFirstname(splitted[0]);
        setLastname(splitted[1]);
        setAge(Integer.parseInt(splitted[2]));
        setHobby(splitted[3]);
    }

    public Person(String firstname, String lastname, int age, String hobby) {
        setFirstname(firstname);
        setLastname(lastname);
        setAge(age);
        setHobby(hobby);
    }
    
// -----------------------------------------------------------------------------    
// setters and getters
// -----------------------------------------------------------------------------
    
    public String getFirstname() {
        return firstname;
    }

    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    public String getLastname() {
        return lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }
    
    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        if((age > 0) && (age < 150)){
            this.age = age;
        }
        else{
            System.out.println("Invalid age!");
        }
    }

    public String getHobby() {
        return hobby;
    }

    public void setHobby(String hobby) {
        this.hobby = hobby;
    }
    
}
