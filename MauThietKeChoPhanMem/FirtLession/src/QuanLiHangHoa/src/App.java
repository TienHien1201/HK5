package QuanLiHangHoa.src;
public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Hello, World!");
    }
}



// package QuanLiHangHoa.src.presentation;

// import javax.swing.*;
// import javax.swing.event.ListSelectionEvent;
// import javax.swing.event.ListSelectionListener;
// import javax.swing.table.DefaultTableModel;
// import java.awt.event.ActionEvent;
// import java.awt.event.ActionListener;
// import java.text.ParseException;
// import java.text.SimpleDateFormat;
// import java.util.Date;
// import java.util.List;
// import QuanLiHangHoa.src.domain.ChucNang;
// import QuanLiHangHoa.src.domain.model.HangDienMay;
// import QuanLiHangHoa.src.domain.model.HangSanhSu;
// import QuanLiHangHoa.src.domain.model.HangThucPham;

// public class HangHoaController {
//     private QuanLiHangHoaUI ui;
//     private DefaultTableModel tableModel;
//     private SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");
//     private ChucNang chucNang;

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

//     public HangHoaController(QuanLiHangHoaUI ui, ChucNang chucNang) {
//         this.ui = ui;
//         this.chucNang = chucNang;
//         tableModel = (DefaultTableModel) ui.tableRemote.getModel();
//         initializeActions();
//         initializeTableSelection();
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
//         ui.getBtnSuaRemote().addActionListener(e -> handleUpdateButtonClick());
//     }

//     private void initializeTableSelection() {
//         ui.tableRemote.getSelectionModel().addListSelectionListener(new ListSelectionListener() {
//             @Override
//             public void valueChanged(ListSelectionEvent e) {
//                 int selectedRow = ui.tableRemote.getSelectedRow();
//                 if (selectedRow >= 0) {
//                     updateTextFields(selectedRow);
//                 }
//             }
//         });
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
// private void handleUpdateButtonClick() {
//     int selectedRow = ui.tableRemote.getSelectedRow();
//     if (selectedRow >= 0) {
//         try {
//             if (ui.getPanelHangThucPhamRemote().isVisible()) {
//                 updateHangThucPham(selectedRow);
//             } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
//                 updateHangSanhSu(selectedRow);
//             } else if (ui.getPanelHangDienMayRemote().isVisible()) {
//                 updateHangDienMay(selectedRow);
//             }
//         } catch (ClassNotFoundException ex) {
//             ex.printStackTrace();
//             JOptionPane.showMessageDialog(ui, "Lỗi cập nhật: " + ex.getMessage(), "Thông báo", JOptionPane.ERROR_MESSAGE);
//         }
//     }
// }


//     private void updateTextFields(int row) {
//         Object[] rowData = convertToTableRow(ui.tableRemote.getValueAt(row, 0));
//         if (ui.getPanelHangThucPhamRemote().isVisible()) {
//             ui.getTxtMaHangRemote().setText((String) rowData[0]);
//             ui.getTxtTenHangRemote().setText((String) rowData[1]);
//             ui.getTxtNgaySanXuatRemote().setText((String) rowData[2]);
//             ui.getTxtNgayHetHanRemote().setText((String) rowData[3]);
//             ui.getTxtSoLuongRemote().setText(String.valueOf(rowData[4]));
//             ui.getTxtSoLuongTonRemote().setText(String.valueOf(rowData[5]));
//             ui.getTxtDonGiaRemote().setText(String.valueOf(rowData[6]));
//             ui.getTxtNhaCungCapRemote().setText((String) rowData[7]);
//         } else if (ui.getPanelHangSanhSuRemote().isVisible()) {
//             ui.getTxtMaHangRemote().setText((String) rowData[0]);
//             ui.getTxtTenHangRemote().setText((String) rowData[1]);
//             ui.getTxtNhaSanXuatRemote().setText((String) rowData[2]);
//             ui.getTxtNgayNhapKhoRemote().setText((String) rowData[3]);
//             ui.getTxtSoLuongRemote().setText(String.valueOf(rowData[4]));
//             ui.getTxtSoLuongTonRemote().setText(String.valueOf(rowData[5]));
//             ui.getTxtDonGiaRemote().setText(String.valueOf(rowData[6]));
//         } else if (ui.getPanelHangDienMayRemote().isVisible()) {
//             ui.getTxtMaHangRemote().setText((String) rowData[0]);
//             ui.getTxtTenHangRemote().setText((String) rowData[1]);
//             ui.getTxtThoiGianBaoHanhThangRemote().setText((String) rowData[2]);
//             ui.getTxtCongSuatRemote().setText((String) rowData[3]);
//             ui.getTxtSoLuongRemote().setText(String.valueOf(rowData[4]));
//             ui.getTxtSoLuongTonRemote().setText(String.valueOf(rowData[5]));
//             ui.getTxtDonGiaRemote().setText(String.valueOf(rowData[6]));
//         }
//     }

//     private void addHangThucPham() {
//         if (validateHangThucPhamInput()) {
//             HangThucPham hangThucPham = new HangThucPham(
//                 ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
//                 ui.getTxtMaHangRemote().getText().trim(), // maloaihang
//                 Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
//                 Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
//                 Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
//                 0.0, // thueVat, bạn có thể thay đổi theo yêu cầu
//                 convertToDate(ui.getTxtNgaySanXuatRemote().getText().trim()), // ngaysanxuat
//                 convertToDate(ui.getTxtNgayHetHanRemote().getText().trim()), // ngayhethan
//                 ui.getTxtNhaCungCapRemote().getText().trim() // nhacungcap
//             );
//             chucNang.Them(hangThucPham);
//             loadHangThucPhamData();
//         }
//     }

//     private void addHangSanhSu() {
//         if (validateHangSanhSuInput()) {
//             HangSanhSu hangSanhSu = new HangSanhSu(
//                 ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
//                 ui.getTxtMaHangRemote().getText().trim(), // maloaihang
//                 Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
//                 Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
//                 Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
//                 0.0, // thueVat, bạn có thể thay đổi theo yêu cầu
//                 ui.getTxtNhaSanXuatRemote().getText().trim(), // nhacungcap
//                 convertToDate(ui.getTxtNgayNhapKhoRemote().getText().trim()) // ngaynhapkho
//             );
//             chucNang.Them(hangSanhSu);
//             loadHangSanhSuData();
//         }
//     }

//     private void addHangDienMay() {
//         if (validateHangDienMayInput()) {
//             HangDienMay hangDienMay = new HangDienMay(
//                 ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
//                 ui.getTxtMaHangRemote().getText().trim(), // maloaihang
//                 ui.getTxtThoiGianBaoHanhThangRemote().getText().trim(), // thoigianbaohanh
//                 ui.getTxtCongSuatRemote().getText().trim(), // congsuat
//                 Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
//                 Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
//                 Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
//                 0.0 // thueVat, bạn có thể thay đổi theo yêu cầu
//             );
//             chucNang.Them(hangDienMay);
//             loadHangDienMayData();
//         }
//     }

//     private void updateHangThucPham(int row) throws ClassNotFoundException {
//         HangThucPham hangThucPham = new HangThucPham(
//             ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
//             ui.getTxtMaHangRemote().getText().trim(), // maloaihang
//             Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
//             Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
//             Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
//             0.0, // thueVat, bạn có thể thay đổi theo yêu cầu
//             convertToDate(ui.getTxtNgaySanXuatRemote().getText().trim()), // ngaysanxuat
//             convertToDate(ui.getTxtNgayHetHanRemote().getText().trim()), // ngayhethan
//             ui.getTxtNhaCungCapRemote().getText().trim() // nhacungcap
//         );
//         chucNang.Sua(hangThucPham);
//         loadHangThucPhamData();
//     }

//     private void updateHangSanhSu(int row) throws ClassNotFoundException {
//         HangSanhSu hangSanhSu = new HangSanhSu(
//             ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
//             ui.getTxtMaHangRemote().getText().trim(), // maloaihang
//             Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
//             Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
//             Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
//             0.0, // thueVat, bạn có thể thay đổi theo yêu cầu
//             ui.getTxtNhaSanXuatRemote().getText().trim(), // nhacungcap
//             convertToDate(ui.getTxtNgayNhapKhoRemote().getText().trim()) // ngaynhapkho
//         );
//         chucNang.Sua(hangSanhSu);
//         loadHangSanhSuData();
//     }

//     private void updateHangDienMay(int row) throws ClassNotFoundException {
//         HangDienMay hangDienMay = new HangDienMay(
//             ui.getTxtTenHangRemote().getText().trim(), // tenloaihang
//             ui.getTxtMaHangRemote().getText().trim(), // maloaihang
//             ui.getTxtThoiGianBaoHanhThangRemote().getText().trim(), // thoigianbaohanh
//             ui.getTxtCongSuatRemote().getText().trim(), // congsuat
//             Integer.parseInt(ui.getTxtSoLuongRemote().getText().trim()), // soluong
//             Integer.parseInt(ui.getTxtSoLuongTonRemote().getText().trim()), // soLuongTonkho
//             Double.parseDouble(ui.getTxtDonGiaRemote().getText().trim()), // dongia
//             0.0 // thueVat, bạn có thể thay đổi theo yêu cầu
//         );
//         chucNang.Sua(hangDienMay);
//         loadHangDienMayData();
//     }

//     private boolean validateHangThucPhamInput() {
//         return !isAnyFieldEmpty(
//             ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtNgaySanXuatRemote(),
//             ui.getTxtNgayHetHanRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote(), ui.getTxtNhaCungCapRemote()
//         );
//     }

//     private boolean validateHangSanhSuInput() {
//         return !isAnyFieldEmpty(
//             ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtNhaSanXuatRemote(),
//             ui.getTxtNgayNhapKhoRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote()
//         );
//     }

//     private boolean validateHangDienMayInput() {
//         return !isAnyFieldEmpty(
//             ui.getTxtMaHangRemote(), ui.getTxtTenHangRemote(), ui.getTxtThoiGianBaoHanhThangRemote(),
//             ui.getTxtCongSuatRemote(), ui.getTxtSoLuongRemote(), ui.getTxtSoLuongTonRemote(), ui.getTxtDonGiaRemote()
//         );
//     }

//     private boolean isAnyFieldEmpty(JTextField... fields) {
//         for (JTextField field : fields) {
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

//     public void loadHangThucPhamData() {
//         List<HangThucPham> hangThucPhamList = chucNang.getHangThucPham();
//         updateTable(hangThucPhamList);
//     }

//     public void loadHangSanhSuData() {
//         List<HangSanhSu> hangSanhSuList = chucNang.getHangSanhSu();
//         updateTable(hangSanhSuList);
//     }

//     public void loadHangDienMayData() {
//         List<HangDienMay> hangDienMayList = chucNang.getHangDienMay();
//         updateTable(hangDienMayList);
//     }

//     private void updateTable(List<?> dataList) {
//         tableModel.setRowCount(0);
//         for (Object obj : dataList) {
//             tableModel.addRow(convertToTableRow(obj));
//         }
//     }

//     private Object[] convertToTableRow(Object obj) {
//         if (obj instanceof HangThucPham) {
//             HangThucPham h = (HangThucPham) obj;
//             return new Object[]{
//                 h.getMaloaihang(), h.getTenloaihang(), h.getNgaysanxuat(), h.getNgayhethan(),
//                 h.getSoluong(), h.getSoLuongTonkho(), h.getDongia(), h.getNahcungcap()
//             };
//         } else if (obj instanceof HangSanhSu) {
//             HangSanhSu h = (HangSanhSu) obj;
//             return new Object[]{
//                 h.getMaloaihang(), h.getTenloaihang(), h.getNhacungcap(), h.getNgaynhapkho(),
//                 h.getSoluong(), h.getSoluong(), h.getDongia()
//             };
//         } else if (obj instanceof HangDienMay) {
//             HangDienMay h = (HangDienMay) obj;
//             return new Object[]{
//                 h.getMaloaihang(), h.getTenloaihang(), h.getThoigianbaohanh(), h.getCongsuat(),
//                 h.getSoluong(), h.getSoLuongTonkho(), h.getDongia()
//             };
//         }
//         return new Object[0];
//     }

//     private java.sql.Date convertToDate(String dateStr) {
//         try {
//             Date utilDate = dateFormat.parse(dateStr.trim());
//             return new java.sql.Date(utilDate.getTime());
//         } catch (ParseException e) {
//             e.printStackTrace();
//             JOptionPane.showMessageDialog(ui, "Lỗi định dạng ngày: " + dateStr, "Thông báo", JOptionPane.WARNING_MESSAGE);
//             return null;
//         }
//     }
// }
