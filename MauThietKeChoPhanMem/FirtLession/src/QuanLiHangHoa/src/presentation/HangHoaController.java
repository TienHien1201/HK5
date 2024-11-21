// package QuanLiHangHoa.src.presentation;

// import javax.swing.table.DefaultTableModel;
// import java.awt.event.ActionEvent;
// import java.awt.event.ActionListener;
// import java.sql.Connection;
// import java.sql.PreparedStatement;
// import java.sql.ResultSet;
// import java.sql.Statement;
// import java.text.ParseException;
// import java.text.SimpleDateFormat;
// import java.util.Date;
// import QuanLiHangHoa.src.persistence.DatabaseConnection;

// public class HangHoaController {
//     private QuanLiHangHoaUI ui;
//     private DefaultTableModel tableModel;
//     private SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");

//     private static final String[] HANG_THUC_PHAM_COLUMNS = {
//         "Mã hàng", "Tên hàng", "Ngày sản xuất", "Ngày hết hạn", 
//         "Số lượng", "Số lượng tồn kho", "Đơn giá", "Nhà cung cấp", "Thuế VAT"
//     };

//     private static final String[] HANG_SANH_SU_COLUMNS = {
//         "Mã hàng", "Tên hàng", "Nhà cung cấp", "Ngày nhập kho", 
//         "Số lượng", "Số lượng tồn kho", "Đơn giá", "Thuế VAT"
//     };

//     private static final String[] HANG_DIEN_MAY_COLUMNS = {
//         "Mã hàng", "Tên hàng", "Thời gian bảo hành", "Công suất", 
//         "Số lượng", "Số lượng tồn kho", "Đơn giá", "Thuế VAT"
//     };

//     public HangHoaController(QuanLiHangHoaUI ui) {
//         this.ui = ui;
//         tableModel = (DefaultTableModel) ui.tableRemote.getModel();
//         initializeActions();
//     }

//     private void initializeActions() {
//         ui.getMenuItemHangThucPhamRemote().addActionListener(e -> {
//             showHangThucPhamPanel();
//             loadHangThucPhamData();
//         });

//         ui.getMenuItemHangSanhSuRemote().addActionListener(e -> {
//             showHangSanhSuPanel();
//             loadHangSanhSuData();
//         });

//         ui.getMenuItemHangDienMayRemote().addActionListener(e -> {
//             showHangDienMayPanel();
//             loadHangDienMayData();
//         });

//         ui.getBtnThemRemote().addActionListener(e -> handleAddButtonClick());
//     }

//     private void handleAddButtonClick() {
//         if (ui.getPanelHangThucPhamRemote().isVisible()) {
//             addHangThucPham();
//         } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
//             addHangSanhSu();
//         } else if (ui.getPanelHangDienMayRemote().isVisible()) {
//             addHangDienMay();
//         }
//     }

//     private java.sql.Date convertToDate(String dateStr) {
//         try {
//             Date utilDate = dateFormat.parse(dateStr.trim());
//             return new java.sql.Date(utilDate.getTime());
//         } catch (ParseException e) {
//             e.printStackTrace();
//             javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi định dạng ngày: " + dateStr, "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
//             return null;
//         }
//     }

//     private void addHangThucPham() {
//         if (validateHangThucPhamInput()) {
//             try (Connection conn = DatabaseConnection.getConnection()) {
//                 String sqlInsert = "INSERT INTO hangthucpham (maloaihang, tenloaihang, ngaysanxuat, ngayHetHan, soluong, SoLuongTonkho, dongia, nhacungcap, ThueVat) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
//                 PreparedStatement pstmtInsert = conn.prepareStatement(sqlInsert);

//                 pstmtInsert.setString(1, ui.getTxtMaHangRemote().getText().trim());
//                 pstmtInsert.setString(2, ui.getTxtTenHangRemote().getText().trim());
//                 pstmtInsert.setDate(3, convertToDate(ui.getTxtNgaySanXuatRemote().getText().trim()));
//                 pstmtInsert.setDate(4, convertToDate(ui.getTxtNgayHetHanRemote().getText().trim()));
//                 pstmtInsert.setInt(5, Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()));
//                 pstmtInsert.setInt(6, Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()));
//                 pstmtInsert.setDouble(7, Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()));
//                 pstmtInsert.setString(8, ui.getTxtNhaCungCapRemote().getText().trim());
//                 pstmtInsert.setString(9, null);

//                 pstmtInsert.executeUpdate();
//                 loadHangThucPhamData();
//             } catch (NumberFormatException ex) {
//                 javax.swing.JOptionPane.showMessageDialog(ui, "Dữ liệu không hợp lệ: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
//             } catch (Exception ex) {
//                 ex.printStackTrace();
//                 javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi khi thêm hàng thực phẩm: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
//             }
//         }
//     }

//     private void addHangSanhSu() {
//         if (validateHangSanhSuInput()) {
//             try (Connection conn = DatabaseConnection.getConnection()) {
//                 String sqlInsert = "INSERT INTO hangsanhsu (maloaihang, tenloaihang, nhacungcap, ngaynhapkho, soluong, SoLuongTonkho, dongia, ThueVat) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
//                 PreparedStatement pstmtInsert = conn.prepareStatement(sqlInsert);

//                 pstmtInsert.setString(1, ui.getTxtMaHangRemote().getText().trim());
//                 pstmtInsert.setString(2, ui.getTxtTenHangRemote().getText().trim());
//                 pstmtInsert.setString(3, ui.getTxtNhaSanXuatRemote().getText().trim());
//                 pstmtInsert.setDate(4, convertToDate(ui.getTxtNgayNhapKhoRemote().getText().trim()));
//                 pstmtInsert.setInt(5, Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()));
//                 pstmtInsert.setInt(6, Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()));
//                 pstmtInsert.setDouble(7, Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()));
//                 pstmtInsert.setString(8, null);

//                 pstmtInsert.executeUpdate();
//                 loadHangSanhSuData();
//             } catch (NumberFormatException ex) {
//                 javax.swing.JOptionPane.showMessageDialog(ui, "Dữ liệu không hợp lệ: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
//             } catch (Exception ex) {
//                 ex.printStackTrace();
//                 javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi khi thêm hàng sành sứ: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
//             }
//         }
//     }

//     private void addHangDienMay() {
//         if (validateHangDienMayInput()) {
//             try (Connection conn = DatabaseConnection.getConnection()) {
//                 String sqlInsert = "INSERT INTO hangdienmay (maloaihang, tenloaihang, thoigianbaohanh, congsuat, soluong, SoLuongTonkho, dongia, ThueVat) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
//                 PreparedStatement pstmtInsert = conn.prepareStatement(sqlInsert);

//                 pstmtInsert.setString(1, ui.getTxtMaHangRemote().getText().trim());
//                 pstmtInsert.setString(2, ui.getTxtTenHangRemote().getText().trim());
//                 pstmtInsert.setString(3, ui.getTxtThoiGianBaoHanhThangRemote().getText().trim());
//                 pstmtInsert.setString(4, ui.getTxtCongSuatRemote().getText().trim());
//                 pstmtInsert.setInt(5, Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()));
//                 pstmtInsert.setInt(6, Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()));
//                 pstmtInsert.setDouble(7, Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()));
//                 pstmtInsert.setString(8, null);

//                 pstmtInsert.executeUpdate();
//                 loadHangDienMayData(); 
//             } catch (NumberFormatException ex) {
//                 javax.swing.JOptionPane.showMessageDialog(ui, "Dữ liệu không hợp lệ: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
//             } catch (Exception ex) {
//                 ex.printStackTrace();
//                 javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi khi thêm hàng điện máy: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
//             }
//         }
//     }

//     private boolean validateHangThucPhamInput() {
//         if (isAnyFieldEmpty(ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtNgaySanXuatRemote(),
//                 ui.getTxtNgayHetHanRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote(), ui.getTxtNhaCungCapRemote())) {
//             javax.swing.JOptionPane.showMessageDialog(ui, "Vui lòng điền đầy đủ các trường.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
//             return false;
//         }
//         return true;
//     }

//     private boolean validateHangSanhSuInput() {
//         if (isAnyFieldEmpty(ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtNhaSanXuatRemote(),
//                 ui.getTxtNgayNhapKhoRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote())) {
//             javax.swing.JOptionPane.showMessageDialog(ui, "Vui lòng điền đầy đủ các trường.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
//             return false;
//         }
//         return true;
//     }

//     private boolean validateHangDienMayInput() {
//         if (isAnyFieldEmpty(ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtThoiGianBaoHanhThangRemote(),
//                 ui.getTxtCongSuatRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote())) {
//             javax.swing.JOptionPane.showMessageDialog(ui, "Vui lòng điền đầy đủ các trường.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
//             return false;
//         }
//         return true;
//     }

//     private boolean isAnyFieldEmpty(javax.swing.JTextField... fields) {
//         for (javax.swing.JTextField field : fields) {
//             if (field.getText().trim().isEmpty()) {
//                 return true;
//             }
//         }
//         return false;
//     }

//     public void showHangThucPhamPanel() {
//         ui.getPanelChungRemote().setVisible(true);
//         ui.getPanelHangSanhSuRemote().setVisible(false);
//         ui.getPanelHangDienMayRemote().setVisible(false);
//         ui.getPanelHangThucPhamRemote().setVisible(true);
//         tableModel.setColumnIdentifiers(HANG_THUC_PHAM_COLUMNS);
//     }

//     public void showHangSanhSuPanel() {
//         ui.getPanelChungRemote().setVisible(true);
//         ui.getPanelHangThucPhamRemote().setVisible(false);
//         ui.getPanelHangDienMayRemote().setVisible(false);
//         ui.getPanelHangSanhSuRemote().setVisible(true);
//         tableModel.setColumnIdentifiers(HANG_SANH_SU_COLUMNS);
//     }

//     public void showHangDienMayPanel() {
//         ui.getPanelChungRemote().setVisible(true);
//         ui.getPanelHangThucPhamRemote().setVisible(false);
//         ui.getPanelHangSanhSuRemote().setVisible(false);
//         ui.getPanelHangDienMayRemote().setVisible(true);
//         tableModel.setColumnIdentifiers(HANG_DIEN_MAY_COLUMNS);
//     }

//     private void loadHangThucPhamData() {
//         loadData("SELECT * FROM hangthucpham", HANG_THUC_PHAM_COLUMNS);
//     }

//     private void loadHangSanhSuData() {
//         loadData("SELECT * FROM hangsanhsu", HANG_SANH_SU_COLUMNS);
//     }

//     private void loadHangDienMayData() {
//         loadData("SELECT * FROM hangdienmay", HANG_DIEN_MAY_COLUMNS);
//     }

//     private void loadData(String query, String[] columns) {
//         try (Connection conn = DatabaseConnection.getConnection(); 
//              Statement stmt = conn.createStatement();
//              ResultSet rs = stmt.executeQuery(query)) {

//             tableModel.setColumnIdentifiers(columns);
//             tableModel.setRowCount(0);

//             while (rs.next()) {
//                 Object[] rowData = new Object[columns.length];
//                 for (int i = 0; i < columns.length; i++) {
//                     rowData[i] = rs.getObject(i + 1);
//                 }
//                 tableModel.addRow(rowData);
//             }
//         } catch (Exception ex) {
//             ex.printStackTrace();
//             javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi khi tải dữ liệu: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
//         }
//     }
// }

package QuanLiHangHoa.src.presentation;
import javax.swing.table.DefaultTableModel;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import QuanLiHangHoa.src.domain.ChucNang;
import QuanLiHangHoa.src.domain.model.HangDienMay;
import QuanLiHangHoa.src.domain.model.HangSanhSu;
import QuanLiHangHoa.src.domain.model.HangThucPham;
import QuanLiHangHoa.src.persistence.DatabaseConnection;
import QuanLiHangHoa.src.persistence.HangHoaPersistenceService;

public class HangHoaController {
    private QuanLiHangHoaUI ui;
    private DefaultTableModel tableModel;
      private HangHoaPersistenceService persistenceService;
    private SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");
    private ChucNang chucNang;

    private static final String[] HANG_THUC_PHAM_COLUMNS = {
        "Mã hàng", "Tên hàng", "Ngày sản xuất", "Ngày hết hạn", 
        "Số lượng", "Số lượng tồn kho", "Đơn giá", "Nhà cung cấp", "Thuế VAT"
    };

    private static final String[] HANG_SANH_SU_COLUMNS = {
        "Mã hàng", "Tên hàng", "Nhà cung cấp", "Ngày nhập kho", 
        "Số lượng", "Số lượng tồn kho", "Đơn giá", "Thuế VAT"
    };

    private static final String[] HANG_DIEN_MAY_COLUMNS = {
        "Mã hàng", "Tên hàng", "Thời gian bảo hành", "Công suất", 
        "Số lượng", "Số lượng tồn kho", "Đơn giá", "Thuế VAT"
    };

      public HangHoaController(QuanLiHangHoaUI ui, ChucNang chucNang, HangHoaPersistenceService persistenceService) {
        this.ui = ui;
        this.chucNang = chucNang;
        this.persistenceService = persistenceService; // Initialize the persistence service
        tableModel = (DefaultTableModel) ui.tableRemote.getModel();
        initializeActions();
    }
 private void initializeActions() {
    ui.getMenuItemHangThucPhamRemote().addActionListener(e -> {
        showHangThucPhamPanel();
        loadHangThucPhamData();
    });

    ui.getMenuItemHangSanhSuRemote().addActionListener(e -> {
        showHangSanhSuPanel();
        loadHangSanhSuData();
    });

    ui.getMenuItemHangDienMayRemote().addActionListener(e -> {
        showHangDienMayPanel();
        loadHangDienMayData();
    });

    ui.getBtnThemRemote().addActionListener(e -> {
        try {
            handleAddButtonClick();
        } catch (ClassNotFoundException e1) {
            e1.printStackTrace();
        }
    });

    ui.getBtnSuaRemote().addActionListener(e -> handleEditButtonClick()); // Cập nhật nút chỉnh sửa

    ui.getBtnXoaRemote().addActionListener(e -> handleDeleteButtonClick()); // Thêm xử lý cho nút xóa

    ui.getBtnTimKiemRemote().addActionListener(e -> handleSearchButtonClick());

    ui.getBtnTongSoLuongRemote().addActionListener(e -> handleCalculateTotalQuantity()); // Thêm hành động cho nút tính tổng
}

private void handleCalculateTotalQuantity() {
    try {
        Double totalQuantity = 0.0;
        if (ui.getPanelHangThucPhamRemote().isVisible()) {
            totalQuantity = persistenceService.TongSoLuong("HangThucPham");
        } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
            totalQuantity = persistenceService.TongSoLuong("HangSanhSu");
        } else if (ui.getPanelHangDienMayRemote().isVisible()) {
            totalQuantity = persistenceService.TongSoLuong("HangDienMay");
        } else {
            javax.swing.JOptionPane.showMessageDialog(ui, "Vui lòng chọn loại hàng.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            return;
        }

        javax.swing.JOptionPane.showMessageDialog(ui, "Tổng số lượng: " + totalQuantity, "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
    } catch (ClassNotFoundException e) {
        javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi kết nối cơ sở dữ liệu.", "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
        e.printStackTrace();
    }
}

private void handleDeleteButtonClick() {
    String maLoaiHang = ui.getTxtMaHangRemote().getText().trim();

    try {
        boolean deleted = false; // Biến kiểm tra xem có xóa thành công không

        if (ui.getPanelHangThucPhamRemote().isVisible()) {
            HangThucPham existingHangThucPham = chucNang.timKiemHangThucPham(maLoaiHang);
            if (existingHangThucPham != null) {
                persistenceService.delete(maLoaiHang);
                UploadHangThucPhamData(); // Cập nhật dữ liệu trong bảng
                deleted = true; // Đã xóa thành công
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng không tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            }
        } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
            HangSanhSu existingHangSanhSu = chucNang.timKiemHangSanhSu(maLoaiHang);
            if (existingHangSanhSu != null) {
                persistenceService.delete(maLoaiHang);
                UploadHangSanhSuData(); // Cập nhật dữ liệu trong bảng
                deleted = true; // Đã xóa thành công
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng không tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            }
        } else if (ui.getPanelHangDienMayRemote().isVisible()) {
            HangDienMay existingHangDienMay = chucNang.timKiemHangDienMay(maLoaiHang);
            if (existingHangDienMay != null) {
                persistenceService.delete(maLoaiHang);
                UploadHangDienMayData(); // Cập nhật dữ liệu trong bảng
                deleted = true; // Đã xóa thành công
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng không tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            }
        }

        if (deleted) {
            javax.swing.JOptionPane.showMessageDialog(ui, "Xóa thành công.", "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
        }
    } catch (ClassNotFoundException e) {
        javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi kết nối cơ sở dữ liệu.", "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
        e.printStackTrace();
    } catch (NumberFormatException e) {
        javax.swing.JOptionPane.showMessageDialog(ui, "Dữ liệu nhập vào không hợp lệ.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
    }
}


    private void handleEditButtonClick() {
    String maLoaiHang = ui.getTxtMaHangRemote().getText().trim();

    try {
        if (ui.getPanelHangThucPhamRemote().isVisible()) {
            HangThucPham existingHangThucPham = chucNang.timKiemHangThucPham(maLoaiHang);
            if (existingHangThucPham != null) {
                HangThucPham updatedHangThucPham = new HangThucPham(
                    ui.getTxtTenHangRemote().getText().trim(),
                    maLoaiHang,
                    Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()),
                    Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()),
                    Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()),
                   0.0,
                    convertToDate(ui.getTxtNgaySanXuatRemote().getText().trim()),
                    convertToDate(ui.getTxtNgayHetHanRemote().getText().trim()),
                    ui.getTxtNhaCungCapRemote().getText().trim()
                );
                persistenceService.update(updatedHangThucPham);
                UploadHangThucPhamData();
                javax.swing.JOptionPane.showMessageDialog(ui, "Cập nhật hàng thực phẩm thành công.", "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng không tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            }
        } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
            HangSanhSu existingHangSanhSu = chucNang.timKiemHangSanhSu(maLoaiHang);
            if (existingHangSanhSu != null) {
                HangSanhSu updatedHangSanhSu = new HangSanhSu(
                    ui.getTxtTenHangRemote().getText().trim(),
                    maLoaiHang,
                    Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()),
                    Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()),
                    Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()),
                   0.0,
                    ui.getTxtNhaSanXuatRemote().getText().trim(),
                    convertToDate(ui.getTxtNgayNhapKhoRemote().getText().trim())
                );
                persistenceService.update(updatedHangSanhSu);
                UploadHangSanhSuData();
                javax.swing.JOptionPane.showMessageDialog(ui, "Cập nhật hàng sành sứ thành công.", "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng không tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            }
        } else if (ui.getPanelHangDienMayRemote().isVisible()) {
            HangDienMay existingHangDienMay = chucNang.timKiemHangDienMay(maLoaiHang);
            if (existingHangDienMay != null) {
                HangDienMay updatedHangDienMay = new HangDienMay(
                    maLoaiHang,
                    ui.getTxtTenHangRemote().getText().trim(),
                    ui.getTxtThoiGianBaoHanhThangRemote().getText().trim(),
                    ui.getTxtCongSuatRemote().getText().trim(),
                    Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()),
                    Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()),
                    Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()),
                0.0
                );
                persistenceService.update(updatedHangDienMay);
                UploadHangDienMayData();
                javax.swing.JOptionPane.showMessageDialog(ui, "Cập nhật hàng điện máy thành công.", "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng không tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            }
        }
    } catch (ClassNotFoundException e) {
        javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi kết nối cơ sở dữ liệu.", "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
        e.printStackTrace();
    } catch (NumberFormatException e) {
        javax.swing.JOptionPane.showMessageDialog(ui, "Dữ liệu nhập vào không hợp lệ.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
    }
}
private void handleSearchButtonClick() {
    String maLoaiHang = ui.getFind().trim(); // Giả sử bạn có trường tìm kiếm mã hàng

    try {
        if (ui.getPanelHangThucPhamRemote().isVisible()) {
            HangThucPham hangThucPham = chucNang.timKiemHangThucPham(maLoaiHang);
            if (hangThucPham != null) {
                double thue = hangThucPham.getDongia() * 0.05; // Thuế hàng thực phẩm là 5%
                hangThucPham.setThueVat(thue); // Cập nhật thuế vào đối tượng
                updateTableWithHangThucPham(hangThucPham);
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Không tìm thấy hàng thực phẩm với mã loại hàng: " + maLoaiHang, "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
            }
        } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
            HangSanhSu hangSanhSu = chucNang.timKiemHangSanhSu(maLoaiHang);
            if (hangSanhSu != null) {
                double thue = hangSanhSu.getDongia() * 0.10; // Thuế hàng sành sứ là 10%
                hangSanhSu.setThueVat(thue); // Cập nhật thuế vào đối tượng
                updateTableWithHangSanhSu(hangSanhSu);
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Không tìm thấy hàng sành sứ với mã loại hàng: " + maLoaiHang, "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
            }
        } else if (ui.getPanelHangDienMayRemote().isVisible()) {
            HangDienMay hangDienMay = chucNang.timKiemHangDienMay(maLoaiHang);
            if (hangDienMay != null) {
                double thue = hangDienMay.getDongia() * 0.10; // Thuế hàng điện máy là 10%
                hangDienMay.setThueVat(thue); // Cập nhật thuế vào đối tượng
                updateTableWithHangDienMay(hangDienMay);
            } else {
                javax.swing.JOptionPane.showMessageDialog(ui, "Không tìm thấy hàng điện máy với mã loại hàng: " + maLoaiHang, "Thông báo", javax.swing.JOptionPane.INFORMATION_MESSAGE);
            }
        }
    } catch (ClassNotFoundException e) {
        // Handle the exception, e.g., log it or show a message to the user
        javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi kết nối cơ sở dữ liệu.", "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
        e.printStackTrace(); // or log it using a logger
    }
}

private void updateTableWithHangThucPham(HangThucPham hangThucPham) {
    double thueVat = hangThucPham.getDongia() * 0.05; // Tính thuế thực phẩm
    hangThucPham.setThueVat(thueVat); // Cập nhật giá trị thuế

    tableModel.setRowCount(0); // Xóa tất cả các hàng cũ
    Object[] rowData = {
        hangThucPham.getMaloaihang(),
        hangThucPham.getTenloaihang(),
        dateFormat.format(hangThucPham.getNgaysanxuat()),
        dateFormat.format(hangThucPham.getNgayhethan()),
        hangThucPham.getSoluong(),
        hangThucPham.getSoLuongTonkho(),
        hangThucPham.getDongia(),
        hangThucPham.getNahcungcap(),
        hangThucPham.getThueVat()
    };
    tableModel.addRow(rowData);
}
private void updateTableWithHangSanhSu(HangSanhSu hangSanhSu) {
    double thueVat = hangSanhSu.getDongia() * 0.1; // Tính thuế sành sứ
    hangSanhSu.setThueVat(thueVat); // Cập nhật giá trị thuế

    tableModel.setRowCount(0); // Xóa tất cả các hàng cũ
    Object[] rowData = {
        hangSanhSu.getMaloaihang(),
        hangSanhSu.getTenloaihang(),
        hangSanhSu.getNhacungcap(),
        dateFormat.format(hangSanhSu.getNgaynhapkho()),
        hangSanhSu.getSoluong(),
        hangSanhSu.getSoLuongTonkho(),
        hangSanhSu.getDongia(),
        hangSanhSu.getThueVat()
    };
    tableModel.addRow(rowData);
}
private void updateTableWithHangDienMay(HangDienMay hangDienMay) {
    double thueVat = hangDienMay.getDongia() * 0.1; // Tính thuế điện máy
    hangDienMay.setThueVat(thueVat); // Cập nhật giá trị thuế

    tableModel.setRowCount(0); // Xóa tất cả các hàng cũ
    Object[] rowData = {
        hangDienMay.getMaloaihang(),
        hangDienMay.getTenloaihang(),
        hangDienMay.getThoigianbaohanh(),
        hangDienMay.getCongsuat(),
        hangDienMay.getSoluong(),
        hangDienMay.getSoLuongTonkho(),
        hangDienMay.getDongia(),
        hangDienMay.getThueVat()
    };
    tableModel.addRow(rowData);
}


    private java.sql.Date convertToDate(String dateStr) {
        try {
            Date utilDate = dateFormat.parse(dateStr.trim());
            return new java.sql.Date(utilDate.getTime());
        } catch (ParseException e) {
            e.printStackTrace();
            javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi định dạng ngày: " + dateStr, "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            return null;
        }
    }
private void handleAddButtonClick() throws ClassNotFoundException {
    if (ui.getPanelHangThucPhamRemote().isVisible()) {
        if (validateHangThucPhamInput()) {
            if (isHangThucPhamExists(ui.getTxtMaHangRemote().getText().trim())) {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng đã tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            } else {
                addHangThucPham();
            UploadHangThucPhamData();
              
            }
        } else {
            javax.swing.JOptionPane.showMessageDialog(ui, "Vui lòng điền đầy đủ thông tin hàng thực phẩm.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
        }
    } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
        if (validateHangSanhSuInput()) {
            if (isHangSanhSuExists(ui.getTxtMaHangRemote().getText().trim())) {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng đã tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            } else {
                addHangSanhSu();
                UploadHangSanhSuData();
            }
        } else {
            javax.swing.JOptionPane.showMessageDialog(ui, "Vui lòng điền đầy đủ thông tin hàng sành sứ.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
        }
    } else if (ui.getPanelHangDienMayRemote().isVisible()) {
        if (validateHangDienMayInput()) {
            if (isHangDienMayExists(ui.getTxtMaHangRemote().getText().trim())) {
                javax.swing.JOptionPane.showMessageDialog(ui, "Mã loại hàng đã tồn tại.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
            } else {
                addHangDienMay();
               UploadHangDienMayData();
            }
        } else {
            javax.swing.JOptionPane.showMessageDialog(ui, "Vui lòng điền đầy đủ thông tin hàng điện máy.", "Thông báo", javax.swing.JOptionPane.WARNING_MESSAGE);
        }
    }
}

private boolean isHangThucPhamExists(String maLoaiHang) throws ClassNotFoundException {
    return chucNang.timKiemHangThucPham(maLoaiHang) != null;
}

private boolean isHangSanhSuExists(String maLoaiHang) throws ClassNotFoundException {
    return chucNang.timKiemHangSanhSu(maLoaiHang) != null;
}

private boolean isHangDienMayExists(String maLoaiHang) throws ClassNotFoundException {
    return chucNang.timKiemHangDienMay(maLoaiHang) != null;
}
    private void addHangThucPham() throws ClassNotFoundException {
        if (validateHangThucPhamInput()) {
            HangThucPham hangThucPham = new HangThucPham(
                ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
                ui.getTxtMaHangRemote().getText().trim(), // maloaihang
                Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
                Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
                Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
                0.0, // thueVat, bạn có thể thay đổi theo yêu cầu
                convertToDate(ui.getTxtNgaySanXuatRemote().getText().trim()), // ngaysanxuat
                convertToDate(ui.getTxtNgayHetHanRemote().getText().trim()), // ngayhethan
                ui.getTxtNhaCungCapRemote().getText().trim() // nhacungcap
            );
            persistenceService.addHangThucPham(hangThucPham);
            loadHangThucPhamData();
        }
    }

    private void addHangSanhSu() throws ClassNotFoundException {
        if (validateHangSanhSuInput()) {
            HangSanhSu hangSanhSu = new HangSanhSu(
                ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
                ui.getTxtMaHangRemote().getText().trim(), // maloaihang
                Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
                Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
                Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
                0.0, // thueVat, bạn có thể thay đổi theo yêu cầu
                ui.getTxtNhaSanXuatRemote().getText().trim(), // nhacungcap
                convertToDate(ui.getTxtNgayNhapKhoRemote().getText().trim()) // ngaynhapkho
            );
            persistenceService.addHangSanhSu(hangSanhSu);
            loadHangSanhSuData();
        }
    }

    private void addHangDienMay() throws ClassNotFoundException {
        if (validateHangDienMayInput()) {
            HangDienMay hangDienMay = new HangDienMay(
                ui.getTxtMaHangRemote().getText().trim(), // maloaihang
                ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
                ui.getTxtThoiGianBaoHanhThangRemote().getText().trim(), // thoigianbaohanh
                ui.getTxtCongSuatRemote().getText().trim(), // congsuat
                Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
                Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
                Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
                0.0 // thueVat, bạn có thể thay đổi theo yêu cầu
            );
     
            persistenceService.addHangDienMay(hangDienMay);
            loadHangDienMayData();
        }
    }


    private boolean validateHangThucPhamInput() {
        return !isAnyFieldEmpty(
            ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtNgaySanXuatRemote(),
            ui.getTxtNgayHetHanRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote(), ui.getTxtNhaCungCapRemote()
        );
    }

    private boolean validateHangSanhSuInput() {
        return !isAnyFieldEmpty(
            ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtNhaSanXuatRemote(),
            ui.getTxtNgayNhapKhoRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote()
        );
    }

    private boolean validateHangDienMayInput() {
        return !isAnyFieldEmpty(
            ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtThoiGianBaoHanhThangRemote(),
            ui.getTxtCongSuatRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote()
        );
    }

    private boolean isAnyFieldEmpty(javax.swing.JTextField... fields) {
        for (javax.swing.JTextField field : fields) {
            if (field.getText().trim().isEmpty()) {
                return true;
            }
        }
        return false;
    }

    public void showHangThucPhamPanel() {
        ui.getPanelChungRemote().setVisible(true);
        ui.getPanelHangSanhSuRemote().setVisible(false);
        ui.getPanelHangDienMayRemote().setVisible(false);
        ui.getPanelHangThucPhamRemote().setVisible(true);
        tableModel.setColumnIdentifiers(HANG_THUC_PHAM_COLUMNS);
    }

    public void showHangSanhSuPanel() {
        ui.getPanelChungRemote().setVisible(true);
        ui.getPanelHangThucPhamRemote().setVisible(false);
        ui.getPanelHangDienMayRemote().setVisible(false);
        ui.getPanelHangSanhSuRemote().setVisible(true);
        tableModel.setColumnIdentifiers(HANG_SANH_SU_COLUMNS);
    }

    public void showHangDienMayPanel() {
        ui.getPanelChungRemote().setVisible(true);
        ui.getPanelHangThucPhamRemote().setVisible(false);
        ui.getPanelHangSanhSuRemote().setVisible(false);
        ui.getPanelHangDienMayRemote().setVisible(true);
        tableModel.setColumnIdentifiers(HANG_DIEN_MAY_COLUMNS);
    }

    public void loadHangThucPhamData() {
        List<HangThucPham> hangThucPhamList = chucNang.getHangThucPham();
        updateTable(hangThucPhamList);
        
    }

    public void loadHangSanhSuData() {
        List<HangSanhSu> hangSanhSuList = chucNang.getHangSanhSu();
        updateTable(hangSanhSuList);
    }

    public void loadHangDienMayData() {
        List<HangDienMay> hangDienMayList = chucNang.getHangDienMay();
        updateTable(hangDienMayList);
    }

    private void updateTable(List<?> dataList) {
        tableModel.setRowCount(0);
        for (Object obj : dataList) {
            tableModel.addRow(convertToTableRow(obj));
        }
    }

    private Object[] convertToTableRow(Object obj) {
        if (obj instanceof HangThucPham) {
            HangThucPham h = (HangThucPham) obj;
            return new Object[]{
                h.getTenloaihang(), h.getMaloaihang(), h.getNgaysanxuat(), h.getNgayhethan(),
                h.getSoluong(), h.getSoLuongTonkho(), h.getDongia(), h.getNahcungcap()
            };
        } else if (obj instanceof HangSanhSu) {
            HangSanhSu h = (HangSanhSu) obj;
            return new Object[]{
                h.getMaloaihang(), h.getTenloaihang(), h.getNhacungcap(), h.getNgaynhapkho(),
                h.getSoluong(), h.getSoluong(), h.getDongia()
            };
        } else if (obj instanceof HangDienMay) {
            HangDienMay h = (HangDienMay) obj;
            return new Object[]{
                h.getMaloaihang(), h.getTenloaihang(), h.getThoigianbaohanh(), h.getCongsuat(),
                h.getSoluong(), h.getSoLuongTonkho(), h.getDongia()
            };
        }
        return new Object[0];
    }

    
    private void UploadHangThucPhamData() {
        loadData("SELECT * FROM hangthucpham", HANG_THUC_PHAM_COLUMNS);
    }

    private void UploadHangSanhSuData() {
        loadData("SELECT * FROM hangsanhsu", HANG_SANH_SU_COLUMNS);
    }

    private void UploadHangDienMayData() {
        loadData("SELECT * FROM hangdienmay", HANG_DIEN_MAY_COLUMNS);
    }

    private void loadData(String query, String[] columns) {
        try (Connection conn = DatabaseConnection.getConnection(); 
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery(query)) {

            tableModel.setColumnIdentifiers(columns);
            tableModel.setRowCount(0);

            while (rs.next()) {
                Object[] rowData = new Object[columns.length];
                for (int i = 0; i < columns.length; i++) {
                    rowData[i] = rs.getObject(i + 1);
                }
                tableModel.addRow(rowData);
            }
        } catch (Exception ex) {
            ex.printStackTrace();
            javax.swing.JOptionPane.showMessageDialog(ui, "Lỗi khi tải dữ liệu: " + ex.getMessage(), "Thông báo", javax.swing.JOptionPane.ERROR_MESSAGE);
        }
    }
}
