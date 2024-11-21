package QuanLiHangHoa.src.persistence;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import QuanLiHangHoa.src.domain.model.HangDienMay;
import QuanLiHangHoa.src.domain.model.HangHoa;
import QuanLiHangHoa.src.domain.model.HangSanhSu;
import QuanLiHangHoa.src.domain.model.HangThucPham;
public class HangHoaPersistenceServiceImpl implements HangHoaPersistenceService {
    private List<HangDienMay> hangDienMayList = new ArrayList<>();
    private List<HangSanhSu> hangSanhSuList = new ArrayList<>();
    private List<HangThucPham> hangThucPhamList = new ArrayList<>();
    
    @Override
    public void save(Object hang) {
        if (hang instanceof HangDienMay) {
            hangDienMayList.add((HangDienMay) hang);
        } else if (hang instanceof HangSanhSu) {
            hangSanhSuList.add((HangSanhSu) hang);
        } else if (hang instanceof HangThucPham) {
            hangThucPhamList.add((HangThucPham) hang);
        }
    }   
    @Override
public void delete(String maloaihang) throws ClassNotFoundException {
    String deleteQueryDienMay = "DELETE FROM hangdienmay WHERE maloaihang = ?";
    String deleteQuerySanhSu = "DELETE FROM hangsanhsu WHERE maloaihang = ?";
    String deleteQueryThucPham = "DELETE FROM hangthucpham WHERE maloaihang = ?";

    try (Connection conn = DatabaseConnection.getConnection()) {
        // Xóa từ bảng hangdienmay
        try (PreparedStatement stmt = conn.prepareStatement(deleteQueryDienMay)) {
            stmt.setString(1, maloaihang);
            stmt.executeUpdate();
        }

        // Xóa từ bảng hangsangsu
        try (PreparedStatement stmt = conn.prepareStatement(deleteQuerySanhSu)) {
            stmt.setString(1, maloaihang);
            stmt.executeUpdate();
        }

        // Xóa từ bảng hangthucpham
        try (PreparedStatement stmt = conn.prepareStatement(deleteQueryThucPham)) {
            stmt.setString(1, maloaihang);
            stmt.executeUpdate();
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
}

@Override
public void update(HangDienMay hangDienMay) throws ClassNotFoundException {
    String query = "UPDATE hangdienmay SET " +
        "tenloaihang = ?, " +
        "thoigianbaohanh = ?, " +
        "congsuat = ?, " +
        "soluong = ?, " +
        "soluongtonkho = ?, " +
        "dongia = ?, " +
        "thuevat = ? " +
        "WHERE maloaihang = ?";

    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, hangDienMay.getTenloaihang());
        stmt.setString(2, hangDienMay.getThoigianbaohanh());
        stmt.setString(3, hangDienMay.getCongsuat());
        stmt.setInt(4, hangDienMay.getSoluong());
        stmt.setInt(5, hangDienMay.getSoLuongTonkho());
        stmt.setDouble(6, hangDienMay.getDongia());
        stmt.setDouble(7, hangDienMay.getThueVat());
        stmt.setString(8, hangDienMay.getMaloaihang());

        stmt.executeUpdate();
    } catch (SQLException e) {
        e.printStackTrace();
    }
}

@Override
public void update(HangSanhSu hangSanhSu) throws ClassNotFoundException {
    String query = "UPDATE hangsanhsu SET " +
        "tenloaihang = ?, " +
        "soluong = ?, " +
        "dongia = ?, " +
        "soluongtonkho = ?, " +
        "thuevat = ?, " +
        "nhacungcap = ?, " +
        "ngaynhapkho = ? " +
        "WHERE maloaihang = ?";

    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, hangSanhSu.getTenloaihang());
        stmt.setInt(2, hangSanhSu.getSoluong());
        stmt.setDouble(3, hangSanhSu.getDongia());
        stmt.setInt(4, hangSanhSu.getSoLuongTonkho());
        stmt.setDouble(5, hangSanhSu.getThueVat());
        stmt.setString(6, hangSanhSu.getNhacungcap());
        stmt.setDate(7, new java.sql.Date(hangSanhSu.getNgaynhapkho().getTime()));
        stmt.setString(8, hangSanhSu.getMaloaihang());

        stmt.executeUpdate();
    } catch (SQLException e) {
        e.printStackTrace();
    }
}

@Override
public void update(HangThucPham hangThucPham) throws ClassNotFoundException {
    String query = "UPDATE hangthucpham SET " +
        "tenloaihang = ?, " +
        "soluong = ?, " +
        "dongia = ?, " +
        "soluongtonkho = ?, " +
        "thuevat = ?, " +
        "ngaysanxuat = ?, " +
        "ngayhethan = ?, " +
        "nhacungcap = ? " +
        "WHERE maloaihang = ?";

    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, hangThucPham.getTenloaihang());
        stmt.setInt(2, hangThucPham.getSoluong());
        stmt.setDouble(3, hangThucPham.getDongia());
        stmt.setInt(4, hangThucPham.getSoLuongTonkho());
        stmt.setDouble(5, hangThucPham.getThueVat());
        stmt.setDate(6, new java.sql.Date(hangThucPham.getNgaysanxuat().getTime()));
        stmt.setDate(7, new java.sql.Date(hangThucPham.getNgayhethan().getTime()));
        stmt.setString(8, hangThucPham.getNahcungcap());
        stmt.setString(9, hangThucPham.getMaloaihang());

        stmt.executeUpdate();
    } catch (SQLException e) {
        e.printStackTrace();
    }
}@Override
public HangDienMay findHangDienMayById(String id) throws ClassNotFoundException {
    HangDienMay hangDienMay = null;
    String query = "SELECT * FROM hangdienmay WHERE maloaihang = ?";
    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, id);
        try (ResultSet rs = stmt.executeQuery()) {
            if (rs.next()) {
                hangDienMay = new HangDienMay(
                    rs.getString("tenloaihang"),
                    rs.getString("maloaihang"),
                    rs.getString("thoigianbaohanh"),
                    rs.getString("congsuat"),
                    rs.getInt("soluong"),
                    rs.getInt("soluongtonkho"),
                    rs.getDouble("dongia"),
                    rs.getDouble("thuevat")
                );
            }
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
    return hangDienMay;
}

@Override
public HangSanhSu findHangSanhSuById(String id) throws ClassNotFoundException {
    HangSanhSu hangSanhSu = null;
    String query = "SELECT * FROM hangsanhsu WHERE maloaihang = ?";
    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, id);
        try (ResultSet rs = stmt.executeQuery()) {
            if (rs.next()) {
                hangSanhSu = new HangSanhSu(
                    rs.getString("tenloaihang"),
                    rs.getString("maloaihang"),
                    rs.getInt("soluong"),
                    rs.getDouble("dongia"),
                    rs.getInt("soluongtonkho"),
                    rs.getDouble("thuevat"),
                    rs.getString("nhacungcap"),
                    rs.getDate("ngaynhapkho")
                );
            }
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
    return hangSanhSu;
}

@Override
public HangThucPham findHangThucPhamById(String id) throws ClassNotFoundException {
    HangThucPham hangThucPham = null;
    String query = "SELECT * FROM hangthucpham WHERE maloaihang = ?";
    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, id);
        try (ResultSet rs = stmt.executeQuery()) {
            if (rs.next()) {
                hangThucPham = new HangThucPham(
                    rs.getString("maloaihang"),
                    rs.getString("tenloaihang"),
                    rs.getInt("soluong"),
                    rs.getDouble("dongia"),
                    rs.getInt("soluongtonkho"),
                    rs.getDouble("thuevat"),
                    rs.getDate("ngaysanxuat"),
                    rs.getDate("ngayhethan"),
                    rs.getString("nhacungcap")
                );
            }
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
    return hangThucPham;
}


@Override
public List<HangDienMay> getAllHangDienMay() throws ClassNotFoundException {
    List<HangDienMay> result = new ArrayList<>();
    String query = "SELECT * FROM hangdienmay";
    try (Connection conn = DatabaseConnection.getConnection();
         Statement stmt = conn.createStatement();
         ResultSet rs = stmt.executeQuery(query)) {

        while (rs.next()) {
            HangDienMay hang = new HangDienMay(
                rs.getString("tenloaihang"),
                rs.getString("maloaihang"),
                rs.getString("thoigianbaohanh"),
                rs.getString("congsuat"),
                rs.getInt("soluong"),
                rs.getInt("soluongtonkho"),
                rs.getDouble("dongia"),
                rs.getDouble("thuevat")
            );
            result.add(hang);
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
    return result;
}


@Override
public List<HangSanhSu> getAllHangSanhSu() throws ClassNotFoundException {
    List<HangSanhSu> result = new ArrayList<>();
    String query = "SELECT * FROM hangsanhsu";
    try (Connection conn = DatabaseConnection.getConnection();
         Statement stmt = conn.createStatement();
         ResultSet rs = stmt.executeQuery(query)) {

        while (rs.next()) {
            HangSanhSu hang = new HangSanhSu(
                rs.getString("tenloaihang"),
                rs.getString("maloaihang"),
                rs.getInt("soluong"),
                rs.getDouble("dongia"),
                rs.getInt("soluongtonkho"),
                rs.getDouble("thuevat"),
                rs.getString("nhacungcap"),
                rs.getDate("ngaynhapkho")
            );
            result.add(hang);
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
    return result;
}

    @Override
    public List<HangThucPham> getAllHangThucPham() throws ClassNotFoundException {
        List<HangThucPham> result = new ArrayList<>();
    String query = "SELECT * FROM hangthucpham";
    try (Connection conn = DatabaseConnection.getConnection();
         Statement stmt = conn.createStatement();
         ResultSet rs = stmt.executeQuery(query)) {

        while (rs.next()) {
            HangThucPham hang = new HangThucPham(
                rs.getString("maloaihang"),
                rs.getString("tenloaihang"),
                rs.getInt("soluong"),
                rs.getDouble("dongia"),
                rs.getInt("soluongtonkho"),
                rs.getDouble("thuevat"),
                rs.getDate("ngaysanxuat"),
                rs.getDate("ngayhethan"),
                rs.getString("nhacungcap")
            );
            result.add(hang);
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
    return result;
    }
    @Override
    public void addHangThucPham(HangThucPham hangThucPham) throws ClassNotFoundException {
       String query = "INSERT INTO hangthucpham (maloaihang, tenloaihang, soluong, dongia, soluongtonkho, thuevat, ngaysanxuat, ngayhethan, nhacungcap) " +
                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, hangThucPham.getMaloaihang());
        stmt.setString(2, hangThucPham.getTenloaihang());
        stmt.setInt(3, hangThucPham.getSoluong());
        stmt.setDouble(4, hangThucPham.getDongia());
        stmt.setInt(5, hangThucPham.getSoLuongTonkho());
        stmt.setDouble(6, hangThucPham.getThueVat());
        stmt.setDate(7, new java.sql.Date(hangThucPham.getNgaysanxuat().getTime()));
        stmt.setDate(8, new java.sql.Date(hangThucPham.getNgayhethan().getTime()));
        stmt.setString(9, hangThucPham.getNahcungcap());

        stmt.executeUpdate();
    } catch (SQLException e) {
        e.printStackTrace();
    }
    }
    @Override
    public void addHangDienMay(HangDienMay hangDienMay) throws ClassNotFoundException {
        String query = "INSERT INTO hangdienmay (tenloaihang, maloaihang, thoigianbaohanh, congsuat, soluong, soluongtonkho, dongia, thuevat) " +
                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, hangDienMay.getTenloaihang());
        stmt.setString(2, hangDienMay.getMaloaihang());
        stmt.setString(3, hangDienMay.getThoigianbaohanh());
        stmt.setString(4, hangDienMay.getCongsuat());
        stmt.setInt(5, hangDienMay.getSoluong());
        stmt.setInt(6, hangDienMay.getSoLuongTonkho());
        stmt.setDouble(7, hangDienMay.getDongia());
        stmt.setDouble(8, hangDienMay.getThueVat());

        stmt.executeUpdate();
    } catch (SQLException e) {
        e.printStackTrace();
    }
    }
    @Override
    public void addHangSanhSu(HangSanhSu hangSanhSu) throws ClassNotFoundException {
        String query = "INSERT INTO hangsanhsu (tenloaihang, maloaihang, soluong, dongia, soluongtonkho, thuevat, nhacungcap, ngaynhapkho) " +
                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query)) {

        stmt.setString(1, hangSanhSu.getTenloaihang());
        stmt.setString(2, hangSanhSu.getMaloaihang());
        stmt.setInt(3, hangSanhSu.getSoluong());
        stmt.setDouble(4, hangSanhSu.getDongia());
        stmt.setInt(5, hangSanhSu.getSoLuongTonkho());
        stmt.setDouble(6, hangSanhSu.getThueVat());
        stmt.setString(7, hangSanhSu.getNhacungcap());
        stmt.setDate(8, new java.sql.Date(hangSanhSu.getNgaynhapkho().getTime()));

        stmt.executeUpdate();
    } catch (SQLException e) {
        e.printStackTrace();
    }
    }
    public Double TongSoLuong(String loaiHang) throws ClassNotFoundException {
    String query = "";
    if (loaiHang.equalsIgnoreCase("HangThucPham")) {
        query = "SELECT SUM(soluong) AS tongSoLuong FROM hangthucpham";
    } else if (loaiHang.equalsIgnoreCase("HangSanhSu")) {
        query = "SELECT SUM(soluong) AS tongSoLuong FROM hangsanhsu";
    } else if (loaiHang.equalsIgnoreCase("HangDienMay")) {
        query = "SELECT SUM(soluong) AS tongSoLuong FROM hangdienmay";
    } else {
        throw new IllegalArgumentException("Loai hang khong hop le.");
    }

    try (Connection conn = DatabaseConnection.getConnection();
         PreparedStatement stmt = conn.prepareStatement(query);
         ResultSet rs = stmt.executeQuery()) {

        if (rs.next()) {
            return rs.getDouble("tongSoLuong");
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }

    return 0.0;
}
    @Override
    public double tinhThue(HangHoa hangHoa) {
      
        double donGia = hangHoa.getDongia();
        double thue = 0.0;

        if (hangHoa instanceof HangSanhSu) {
            // Đối với hàng sành sứ, thuế là 10% của đơn giá
            thue = donGia * 0.10;
        } else if (hangHoa instanceof HangDienMay) {
            // Đối với hàng điện máy, thuế là 10% của đơn giá
            thue = donGia * 0.10;
        } else if (hangHoa instanceof HangThucPham) {
            // Đối với hàng thực phẩm, thuế là 5% của đơn giá
            thue = donGia * 0.05;
        }

        return thue;
    }
    }


