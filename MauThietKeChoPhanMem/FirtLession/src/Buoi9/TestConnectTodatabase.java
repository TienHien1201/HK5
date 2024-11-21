package Buoi9;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class TestConnectTodatabase {
public static void main(String[] args) throws ClassNotFoundException, SQLException  {
   //Tải driver vào chuong trinh
   Connection connection = null;
    Class.forName("com.mysql.cj.jdbc.Driver");

//Tạo kết nối đến cơ ở dũ liệu Mysql
String url = "jdbc:mysql://localhost:3306/testdb" ;
String user = "root"; 
String password = "8000";
 connection =   DriverManager.getConnection(url, user, password);
 System.out.println(connection.toString());
}
}
