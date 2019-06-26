/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week3day3;


import com.mysql.jdbc.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

/**
 *
 * @author AYBU
 */
public class Sakila {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        Class.forName("com.mysql.jdbc.Connection");
        getActorFilm();
    }
    
    public static void getActorFilm() throws SQLException{
        
        // Database baglantisi
        // Database adi: sakila
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/sakila", "root", "1234");        
        System.out.println("Connected!");
        
        Scanner input = new Scanner(System.in);
        
        System.out.print("Enter actor name: ");
        String actorName = input.next();
        System.out.print("Enter actor surname: ");
        String actorSurname = input.next();
        
        // Adi ve soyadi verilen aktorun actor_id sini getir 
        String query = "SELECT actor_id FROM actor WHERE first_name = ? AND last_name = ?";
        PreparedStatement stm = con.prepareStatement(query);
        stm.setString(1, actorName);
        stm.setString(2, actorSurname);
        
        ResultSet rs = stm.executeQuery();
        rs.next();
        int actor_id = rs.getInt("actor_id");
        
        // Aktorun oynadıgı filmlerin film_id lerini getir
        query = "SELECT film_id FROM film_actor WHERE actor_id = ?";
        stm = con.prepareStatement(query);
        stm.setInt(1, actor_id);
        
        rs = stm.executeQuery();
        
        while(rs.next()){
            int film_id = rs.getInt("film_id");
            // Film basliklarini getir
            query = "SELECT title FROM film WHERE film_id = ? ORDER BY title ASC";
            stm = con.prepareStatement(query);
            stm.setInt(1, film_id);
            
            ResultSet rsTitle = stm.executeQuery();
            rsTitle.next();
            System.out.println(rsTitle.getString("title"));
        }
        
        // Aktorun oynadigi filmlerin sayisini getir
        query = "SELECT COUNT(*) FROM(SELECT film_id FROM film_actor WHERE actor_id = ?) as filmler";
        stm = con.prepareStatement(query);
        stm.setInt(1, actor_id);
        
        rs = stm.executeQuery();
        rs.next();
        int numOfFilms = rs.getInt(1);
        
        System.out.println("Number of films: " + numOfFilms);
        
        rs.close();
        stm.close();
        con.close();
        
    }
    
}
