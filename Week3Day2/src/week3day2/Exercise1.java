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
        String studentName;     // Student name
        String studentSurname;  // Student surname
        String phone;           // Student phone
        String email;           // Student email
        String courseName;      // Course name
        String department;      // Department name
        
        int courseID;
        int departmentID;
        
        // ----------------------------------------- MySql Connection -----------------------------------------
        // Database name is: studentdatabase
        // If you connect your own database you should change it!
        Class.forName("com.mysql.jdbc.Connection");
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");
        
        System.out.println("Connected!");
        
        // --------------------------------------- Take inputs from user ---------------------------------------
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
        
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        ResultSet rs;
        
        // ----------------------- Get courseID and departmentId writing SQL statement ------------------------
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
        
        // --------------------------------- Insert data to database -------------------------------------
        String query = "insert into student(studentName, studentSurname, studentPhone, studentEmail, courseID, departmentID)";
        query += "values(" + "'" +studentName+ "', " + "'" + studentSurname  + "', " + "'" + phone + "', " + "'" + email + "', " + courseID + ", " + departmentID + ")";
        
        int executeUpdate = stm.executeUpdate(query);
        System.out.println("\nData recored to database (Student table)! " + executeUpdate + "\n");
        
        // -------------------------------- Get all records from database --------------------------------
        String select = "SELECT * FROM Student";
        rs = stm.executeQuery(select);
        
        System.out.println("Student ID\t" + "Student Name\t" + "\t" + "Student Surname\t\t" + "\t" + "Phone\t" + "\t\t" + "Email\t\t" + "\t" + "CourseID\t" + "\t" + "DepartmentID");
        System.out.println("----------\t" + "------------\t" + "\t" + "---------------\t\t" + "\t" + "-----\t\t" + "\t" + "-----\t\t" + "\t" + "--------\t" + "\t" + "------------");
        
        // -------------------------------- Write datas to console --------------------------------
        while(rs.next()){
            System.out.println(rs.getString("studentID") + "\t\t" +
                               rs.getString("studentName") + "\t\t\t" +
                               rs.getString("studentSurname") + "\t\t\t\t" +
                               rs.getString("studentPhone") + "\t\t" +
                               rs.getString("studentEmail") + "\t\t" +
                               rs.getInt("courseID") + "\t\t\t" + 
                               rs.getInt("departmentID"));
        }
        
        // -------------------------------- Get number of records --------------------------------
        String selectCount = "SELECT COUNT(studentID) FROM Student";
        rs = stm.executeQuery(selectCount);
        rs.next();
        int rowCount = rs.getInt(1);
        System.out.println("Number of records: " + rowCount);
        
    }
    
}
