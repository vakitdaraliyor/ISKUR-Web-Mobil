/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2day3;

import static com.sun.corba.se.impl.util.Utility.printStackTrace;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.LinkedList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author AYBU
 */
public class FileOperation {

    /**
     * @param args the command line arguments
     */
    public static void evenOrOdd(int number){
        if((number%2) == 0){
            System.out.println(number + " is even");
        }
        else{
            System.out.println(number + " is odd");
        }
    }
    
    public static void main(String[] args) {
        try {
            
            BufferedReader br1 = new BufferedReader(new FileReader(new File("C:\\Users\\AYBU\\Desktop\\number.txt")));
            BufferedReader br2 = new BufferedReader(new FileReader(new File("C:\\Users\\AYBU\\Desktop\\input.txt")));
            
            String num;
            String line;
            
            Person p1;
            Person p2;
            
            LinkedList<Person> personsList1 = new LinkedList<>();
            LinkedList<Person> personsList2 = new LinkedList<>();
            
            // -----------------------------------------------------------------
            //                      EXERCISE - 1
            // Dosyayi satir satir okuma
            // Elde edilen sayinin tek veya cift oldugunu bulma
            //------------------------------------------------------------------
            while((num = br1.readLine()) != null){
                int newNum = Integer.parseInt(num);
                evenOrOdd(newNum);
            }
            
            System.out.println();
            
            // -----------------------------------------------------------------
            //                      EXERCISE - 2
            // Dosyayi satir satir okuma
            // Elde edilen satiri split etmek
            // Split sonucu gelen parametrelerle Person objesi olusturma (2 yol kullanildi)
            // Obje olusturulurken kullanilan yollar;
            //      1-) Tek parametre alan constructor => Person(String line)
            //      2-) 4 parametre alan constructor => Person(String firstname, String lastname, int age, String hobby)
            // Olusturulan objeleri Person listesine ekleme (listemiz LinkedList)
            // Listenin elemanlarini ekrana yazma
            //------------------------------------------------------------------
            while((line = br2.readLine()) != null){
                // First way using 1 parameter constructor => Person(line)
                p1 = new Person(line);
                personsList1.add(p1);
                
                // Second way using 4 parameter constructor => Person(String firstname, String lastname, int age, String hobby)
                String[] splitted = line.split(" ");
                p2 = new Person(splitted[0], splitted[1], Integer.parseInt(splitted[2]), splitted[3]);
                personsList2.add(p2);
            }
            
            System.out.println();
            
            for(int i = 0; i < personsList1.size(); i++){
                System.out.println((i+1) + ". person's firstname: " + personsList1.get(i).getFirstname());
                System.out.println((i+1) + ". person's lastname: " + personsList1.get(i).getLastname());
                System.out.println((i+1) + ". person's age: " + personsList1.get(i).getAge());
                System.out.println((i+1) + ". person's hobby: " + personsList1.get(i).getHobby() + "\n");
            }
            
            for(int i = 0; i < personsList2.size(); i++){
                System.out.println((i+1) + ". person's firstname: " + personsList2.get(i).getFirstname());
                System.out.println((i+1) + ". person's lastname: " + personsList2.get(i).getLastname());
                System.out.println((i+1) + ". person's age: " + personsList2.get(i).getAge());
                System.out.println((i+1) + ". person's hobby: " + personsList2.get(i).getHobby() + "\n");
            }
            
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        
    }
    
}
