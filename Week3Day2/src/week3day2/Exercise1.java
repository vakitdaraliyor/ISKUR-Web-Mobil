/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week3day2;

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
public class Exercise1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        
        Scanner input = new Scanner(System.in);
        String studentName;
        String studentSurname;
        String phone;
        String email;
        String courseName;
        String department;
        
        int courseID;
        int departmentID;
        
        Class.forName("com.mysql.jdbc.Connection");
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");
        
        System.out.println("Connected!");
        
        System.out.print("Enter student name: ");
        studentName = input.nextLine();
        System.out.print("Enter student surname: ");
        studentSurname = input.nextLine().toUpperCase();
        System.out.print("Enter phone: ");
        phone = input.nextLine();
        System.out.print("Enter email: ");
        email = input.nextLine();
        System.out.print("Enter course name: ");
        courseName = input.nextLine();
        System.out.print("Enter department name: ");
        department = input.nextLine();
        
        Statement stm = (Statement)con.createStatement();
        ResultSet rs;
        
        if(courseName.equalsIgnoreCase("MATH")){
            rs = stm.executeQuery("SELECT courseID FROM Courses WHERE courseName = 'MATH'");
            rs.next();
            courseID = rs.getInt("courseID");
            
        }
        else{
            rs = stm.executeQuery("SELECT courseID FROM Courses WHERE courseName = 'CHEM'");
            rs.next();
            courseID = rs.getInt("courseID");
        }
        
        if(department.equalsIgnoreCase("Mathematic")){
            rs = stm.executeQuery("SELECT departmentID FROM Department WHERE departmentName = 'Mathematic'");
            rs.next();
            departmentID = rs.getInt("departmentID");
        }
        else{
            rs = stm.executeQuery("SELECT departmentID FROM Department WHERE departmentName = 'Chemistry'");
            rs.next();
            departmentID = rs.getInt("departmentID");
        }
        
        String query = "insert into student(studentName, studentSurname, studentPhone, studentEmail, courseID, departmentID)";
        query += "values(" + "'" +studentName+ "', " + "'" + studentSurname  + "', " + "'" + phone + "', " + "'" + email + "', " + courseID + ", " + departmentID + ")";
        
        int executeUpdate = stm.executeUpdate(query);
        System.out.println("\nData recored to Student table! " + executeUpdate + "\n");
        
        
        String select = "SELECT * FROM Student";
        rs = stm.executeQuery(select);
        
        System.out.println("Student ID\t" + "Student Name\t" + "\t" + "Student Surname\t\t" + "\t" + "Phone\t" + "\t\t" + "Email\t\t" + "\t" + "CourseID\t" + "\t" + "DepartmentID");
        System.out.println("----------\t" + "------------\t" + "\t" + "---------------\t\t" + "\t" + "-----\t\t" + "\t" + "-----\t\t" + "\t" + "--------\t" + "\t" + "------------");
        
        while(rs.next()){
            System.out.println(rs.getString("studentID") + "\t\t" +
                               rs.getString("studentName") + "\t\t\t" +
                               rs.getString("studentSurname") + "\t\t\t\t" +
                               rs.getString("studentPhone") + "\t\t" +
                               rs.getString("studentEmail") + "\t\t" +
                               rs.getInt("courseID") + "\t\t\t" + 
                               rs.getInt("departmentID"));
        }
        
        String selectCount = "SELECT COUNT(studentID) FROM Student";
        rs = stm.executeQuery(selectCount);
        rs.next();
        int rowCount = rs.getInt(1);
        System.out.println("Number of records: " + rowCount);
        
    }
    
}
