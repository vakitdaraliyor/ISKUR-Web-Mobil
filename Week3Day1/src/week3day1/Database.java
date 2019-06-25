/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week3day1;

import com.mysql.jdbc.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

/**
 *
 * @author AYBU
 */
public class Database {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        
        Class.forName("com.mysql.jdbc.Connection");
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentinformation","root", "1234");
        
        System.out.println("Baglanti saglandi!");
        
        /*String query = "insert into student (studentName, studentsurname, schoolID, studentEmail)";
        query += "values('İsmail', 'MUEZZINOGLU', 120, 'im@hotmail.com')," +
                       "('Emre', 'SOYLU', 130, 'es@hotmail.com')," +
                       "('Polat', 'SEVIM', 140, 'ps@hotmail.com')," +
                       "('Burak', 'CETIN', 150, 'bc@hotmail.com')," +
                       "('Ethem', 'KAYA', 160, 'ek@hotmail.com')";*/
        
        
        Statement stm = (Statement)con.createStatement();
        //int executeUpdate = stm.executeUpdate(query);
        
        //System.out.println("Eklendi!" + executeUpdate);
        
        String select = "SELECT * FROM student";
        String selectCount = "SELECT COUNT(studentID) FROM student";
        
        ResultSet rs = stm.executeQuery(select);
        
        System.out.println("Student ID\t" + "Student Name\t" + "\t" + "Student Surname\t" + "\t" + "SchoolID\tEmail");
        System.out.println("----------\t" + "------------\t" + "\t" + "---------------\t" + "\t" + "--------\t-----");
        while(rs.next()){
            System.out.println(rs.getString("studentID") + "\t\t" +
                               rs.getString("studentName") + "\t\t\t" +
                               rs.getString("studentSurname") + "\t\t\t" +
                               rs.getString("schoolID") + "\t\t" +
                               rs.getString("studentEmail"));
        }
        
        System.out.println();
        
        rs = stm.executeQuery(selectCount);
        
        rs.next();
        int rowCount = rs.getInt(1);
        System.out.println("Number of records: " + rowCount);
        
        rs.close();
        stm.close();
        con.close();
        
    }
    
}
