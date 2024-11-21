package Buoi9;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class InsertDataExample {
    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        // Kết nối cơ sở dữ liệu
        // Tải driver vào chương trình
        Connection connection = null;
        Class.forName("com.mysql.cj.jdbc.Driver");

        // Tạo kết nối đến cơ sở dữ liệu Mysql
        String url = "jdbc:mysql://localhost:3306/testdb";
        String user = "root";
        String password = "8000";
        connection = DriverManager.getConnection(url, user, password);

        // Truy vấn ~ insert
        String sql = "insert into Salary_Grade(Grade, High_Salary, Low_Salary) values(?, ?, ?)";
        // Create statement object
        PreparedStatement stmt = connection.prepareStatement(sql);
        
        // Set values for parameters
        stmt.setInt(1, 6);
        stmt.setInt(2, 50000);
        stmt.setInt(3, 50000);

        // Execute update
        int rowCount = stmt.executeUpdate();

        System.out.println("countsUpdate = " + rowCount);

        // Đóng kết nối
        stmt.close();
        connection.close();
    }
}
