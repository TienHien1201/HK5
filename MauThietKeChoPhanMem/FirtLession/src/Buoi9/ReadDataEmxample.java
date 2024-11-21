package Buoi9;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;



public class ReadDataEmxample {
public static void main(String[] args) throws Exception, SQLException {
    //ket noi den database testdb
     //Tải driver vào chuong trinh
   Connection connection = null;
   java.sql.Statement statement = null;
   ResultSet result = null;
    Class.forName("com.mysql.cj.jdbc.Driver");

//Tạo kết nối đến cơ ở dũ liệu Mysql
String url = "jdbc:mysql://localhost:3306/testdb" ;
String user = "root"; 
String password = "8000";
 connection =   DriverManager.getConnection(url, user, password);
 System.out.println(connection.toString());
 //Truy van
  String sql = "SELECT EMP_ID ,EMP_NAME, EMP_NO FROM testdb.employee;";
        //Statement
        statement = connection.createStatement();
        //Chay cau Sql
        result = statement.executeQuery(sql);



    while (result.next()) {
        System.out.print(" "+ result.getInt(1) );
        System.out.print( " " + result.getString(2) );
        System.out.print(" " + result.getString("EMP_NO")+ "\n");
    }
    statement.close();
            connection.close();

}

}
