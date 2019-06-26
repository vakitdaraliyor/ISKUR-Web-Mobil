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
     * @throws java.lang.ClassNotFoundException
     * @throws java.sql.SQLException
     */
    
    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        
        Scanner input = new Scanner(System.in);
        
        int choice = -1;
        
        // ----------------------------------------- MySql Connection -----------------------------------------
        // Database name is: studentdatabase
        // If you connect your own database you should change it!
        Class.forName("com.mysql.jdbc.Connection");
        
        
        while(choice != 0){
            System.out.println("1)Press 1 to insert student");
            System.out.println("2)Press 2 to delete student");
            System.out.println("3)Press 3 to update student");
            System.out.println("4)Press 4 to list of students");
            System.out.println("5)Press 5 to get number of records");
            System.out.println("6)Press 6 to get student list acording to course name");
            System.out.println("6)Press 0 to exit");
            System.out.print("Choice: ");
            choice = input.nextInt();
            
            switch(choice){     
                case 0:
                    System.out.println("By By!");
                    break;
                case 1:
                    addStudent();
                    break;                
                case 2:
                    deleteStudent();
                    break;                    
                case 3:
                    updateStudent();
                    break;                    
                case 4:
                    getListOfStudent();
                    break;                
                case 5:
                    numOfRecords();
                    break;  
                case 6:
                    getChemAndMath();
                default:
                    break;
            }
        }
        
    }
    
    // --------------------------------- Operations ---------------------------------
    public static void addStudent() throws SQLException {
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        Scanner input = new Scanner(System.in);
        
        String query;
        // --------------------------------------- Take inputs from user ---------------------------------------
        System.out.print("Enter student name: ");
        String studentName = input.next();
        System.out.print("Enter student surname: ");
        String studentSurname = input.next().toUpperCase();
        System.out.print("Enter phone: ");
        String phone = input.next();
        System.out.print("Enter email: ");
        String email = input.next();
        System.out.print("Enter course name: ");
        String courseName = input.next();
        System.out.print("Enter department name: ");
        String department = input.next();
        int courseID = getCourseID(courseName);
        int departmentID = getDepartmentID(department);
        // --------------------------------- Insert data to database -------------------------------------
        query = "insert into student(studentName, studentSurname, studentPhone, studentEmail, courseID, departmentID)";
        query += "values(" + "'" +studentName+ "', " + "'" + studentSurname  + "', " + "'" + phone + "', " + "'" + email + "', " + courseID + ", " + departmentID + ")";
        int executeUpdate = stm.executeUpdate(query);
        System.out.println("\nData recored to database (Student table)! " + executeUpdate + "\n");
        
        stm.close();
        con.close();
    }
    
    public static void deleteStudent() throws SQLException {
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        Scanner input = new Scanner(System.in);
        
        String query;
        int executeUpdate;
        System.out.println("This operation delete student acording to student id");
        System.out.print("Please enter the student id: ");
        int studentID = input.nextInt();
        query = "delete from student WHERE studentID = " + studentID;
        executeUpdate = stm.executeUpdate(query);
        System.out.println("\nStudent deleted! " + executeUpdate + "\n");
        
        stm.close();
        con.close();
    }
    
    public static void updateStudent() throws SQLException {
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        Scanner input = new Scanner(System.in);
        
        String query;
        int executeUpdate;
        System.out.println("Press 1 update name");
        System.out.println("Press 2 update surname");
        System.out.println("Press 3 update phone number");
        System.out.println("Press 4 update email\n");
        System.out.print("Choice: ");
        int updateChoice = input.nextInt();
        if(updateChoice == 1){
            System.out.print("Enter studentID: ");
            int stuID = input.nextInt();
            System.out.print("Enter new student name: ");
            String newName = input.next();
            query = "UPDATE Student SET studentName = '" + newName + "'" + "WHERE studentID = " + stuID;
            executeUpdate = stm.executeUpdate(query);
            if(executeUpdate == 1){
                System.out.println("Updated!\n");
            }
            else{
                System.out.println("Can not update!\n");
            }
        }
        else if(updateChoice == 2){
            System.out.print("Enter studentID: ");
            int stuID = input.nextInt();
            System.out.print("Enter new student surname: ");
            String newSurname = input.next().toUpperCase();
            query = "UPDATE Student SET studentSurname = '" + newSurname + "'" + "WHERE studentID = " + stuID;
            executeUpdate = stm.executeUpdate(query);
            if(executeUpdate == 1){
                System.out.println("Updated!\n");
            }
            else{
                System.out.println("Can not update!\n");
            }
        }
        else if(updateChoice == 3){
            System.out.print("Enter studentID: ");
            int stuID = input.nextInt();
            System.out.print("Enter new phone number: ");
            String newPhone = input.next();
            query = "UPDATE Student SET studentPhone = '" + newPhone + "'" + "WHERE studentID = " + stuID;
            executeUpdate = stm.executeUpdate(query);
            if(executeUpdate == 1){
                System.out.println("Updated!\n");
            }
            else{
                System.out.println("Can not update!\n");
            }
        }
        else{
            System.out.print("Enter studentID: ");
            int stuID = input.nextInt();
            System.out.print("Enter new email: ");
            String newEmail = input.next();
            query = "UPDATE Student SET studentEmail = '" + newEmail + "'" + "WHERE studentID = " + stuID;
            executeUpdate = stm.executeUpdate(query);
            if(executeUpdate == 1){
                System.out.println("Updated!\n");
            }
            else{
                System.out.println("Can not update!\n");
            }
        }
        
        stm.close();
        con.close();
    }

    public static void getListOfStudent() throws SQLException {
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        ResultSet rs;
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
        System.out.println();
        
        rs.close();
        stm.close();
        con.close();
    }

    public static void numOfRecords() throws SQLException {
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        ResultSet rs;
        // -------------------------------- Get number of records --------------------------------
        String selectCount = "SELECT COUNT(studentID) FROM Student";
        rs = stm.executeQuery(selectCount);
        rs.next();
        int rowCount = rs.getInt(1);
        System.out.println("Number of records: " + rowCount + "\n");
        
        rs.close();
        stm.close();
        con.close();
    }
    
    public static void getChemAndMath() throws SQLException{
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        Scanner input = new Scanner(System.in);
        
        System.out.print("Enter course name: ");
        String courseName = input.next().toUpperCase();
        
        int courseID = getCourseID(courseName);
        
        String query = "SELECT * FROM Student WHERE courseID = " + courseID;
        ResultSet rs = stm.executeQuery(query);
        
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
        System.out.println();
        
        rs.close();
        stm.close();
        con.close();
    }
    
    // ----------------------------------- Methods -----------------------------------
    public static int getDepartmentID(String department) throws SQLException {
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        ResultSet rs;
        int departmentID;
        if(department.equalsIgnoreCase("Mathematic")){
            rs = stm.executeQuery("SELECT departmentID FROM Department WHERE departmentName = 'Mathematic'");
            rs.next();
            departmentID = rs.getInt("departmentID");
            rs.close();
            stm.close();
            con.close();
        }
        else{
            rs = stm.executeQuery("SELECT departmentID FROM Department WHERE departmentName = 'Chemistry'");
            rs.next();
            departmentID = rs.getInt("departmentID");
            rs.close();
            stm.close();
            con.close();
        }
        return departmentID;
        
    }

    public static int getCourseID(String courseName) throws SQLException {
        
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");        
        System.out.println("Connected!");
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        
        ResultSet rs;
        int courseID;
        // ----------------------- Get courseID writing SQL statement ------------------------
        if(courseName.equalsIgnoreCase("MATH")){
            rs = stm.executeQuery("SELECT courseID FROM Courses WHERE courseName = 'MATH'");
            rs.next();
            courseID = rs.getInt("courseID");
            rs.close();
            stm.close();
            con.close();
            
        }
        else{
            rs = stm.executeQuery("SELECT courseID FROM Courses WHERE courseName = 'CHEM'");
            rs.next();
            courseID = rs.getInt("courseID");
            rs.close();
            stm.close();
            con.close();
        }
        return courseID;
    }
    
}
