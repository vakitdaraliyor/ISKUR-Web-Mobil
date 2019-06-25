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
        
        int choice = -1;
        
        // ----------------------------------------- MySql Connection -----------------------------------------
        // Database name is: studentdatabase
        // If you connect your own database you should change it!
        Class.forName("com.mysql.jdbc.Connection");
        Connection con = (Connection)DriverManager.getConnection("jdbc:mysql://localhost:3306/studentdatabase","root", "1234");
        
        System.out.println("Connected!");
        
        // ----------------------------------------- Create statement -----------------------------------------
        Statement stm = (Statement)con.createStatement();
        ResultSet rs;
        String query;
        
        while(choice != 0){
            System.out.println("1)Press 1 to insert student");
            System.out.println("2)Press 2 to delete student");
            System.out.println("3)Press 3 to update student");
            System.out.println("4)Press 4 to list of students");
            System.out.println("5)Press 5 to get number of records");
            System.out.println("6)Press 0 to exit");
            System.out.print("Choice: ");
            choice = input.nextInt();
            switch(choice){
                case 1:
                    // --------------------------------------- Take inputs from user ---------------------------------------
                    System.out.print("Enter student name: ");
                    studentName = input.next();
                    System.out.print("Enter student surname: ");
                    studentSurname = input.next().toUpperCase();
                    System.out.print("Enter phone: ");
                    phone = input.next();
                    System.out.print("Enter email: ");
                    email = input.next();
                    System.out.print("Enter course name: ");
                    courseName = input.next();
                    System.out.print("Enter department name: ");
                    department = input.next();

                    courseID = getCourseID(courseName, stm);
                    departmentID = getDepartmentID(department, stm);

                    // --------------------------------- Insert data to database -------------------------------------
                    query = "insert into student(studentName, studentSurname, studentPhone, studentEmail, courseID, departmentID)";
                    query += "values(" + "'" +studentName+ "', " + "'" + studentSurname  + "', " + "'" + phone + "', " + "'" + email + "', " + courseID + ", " + departmentID + ")";

                    int executeUpdate = stm.executeUpdate(query);
                    System.out.println("\nData recored to database (Student table)! " + executeUpdate + "\n");
                    break;
                
                case 2:
                    System.out.println("This operation delete student acording to student id");
                    System.out.print("Please enter the student id: ");
                    int studentID = input.nextInt();
                    query = "delete from student WHERE studentID = " + studentID;
                    executeUpdate = stm.executeUpdate(query);
                    System.out.println("\nStudent deleted! " + executeUpdate + "\n");
                    break;
                    
                case 3:
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
                        String newSurname = input.next();
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
                    break;
                    
                case 4:
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
                    break;
                
                case 5:
                    // -------------------------------- Get number of records --------------------------------
                    String selectCount = "SELECT COUNT(studentID) FROM Student";
                    rs = stm.executeQuery(selectCount);
                    rs.next();
                    int rowCount = rs.getInt(1);
                    System.out.println("Number of records: " + rowCount + "\n");
                    
                default:
                    break;
            }
        }
        
    }

    public static int getDepartmentID(String department, Statement stm) throws SQLException {
        ResultSet rs;
        int departmentID;
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
        return departmentID;
    }

    public static int getCourseID(String courseName, Statement stm) throws SQLException {
        ResultSet rs;
        int courseID;
        // ----------------------- Get courseID and departmentID writing SQL statement ------------------------
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
        return courseID;
    }
    
}
