package QuanLiHangHoa.src.persistence;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DatabaseConnection {
    private static final String URL = "jdbc:mysql://localhost:3306/QLKHSTHI";
    private static final String USER = "root";
    private static final String PASSWORD = "8000";
 
    // Mỗi lần gọi getConnection() sẽ trả về một kết nối mới
    public static Connection getConnection() throws ClassNotFoundException, SQLException {
        Class.forName("com.mysql.cj.jdbc.Driver");
        return DriverManager.getConnection(URL, USER, PASSWORD);
    }
}
