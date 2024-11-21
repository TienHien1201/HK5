package QuanLiHangHoa.src.presentation;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import QuanLiHangHoa.src.persistence.*;
import StudentTemplateApp.src.domain.model.Student;
import QuanLiHangHoa.src.domain.ChucNang;
import QuanLiHangHoa.src.domain.ChucNangImpl;
import QuanLiHangHoa.src.domain.model.HangSanhSu;
import QuanLiHangHoa.src.domain.model.HangDienMay;
import QuanLiHangHoa.src.domain.model.HangThucPham;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class QuanLiHangHoaUI extends JFrame {
    private final ChucNang chucNang;
    private JPanel panelChungRemote, panelHangThucPhamRemote, panelHangDienMayRemote, panelHangSanhSuRemote;
    
    JLabel LabelMaHangRemote,LabelTenHangRemote,LabelSoLuongTonRemote,LabelDonGiaRemote,LabelNgayNhapKhoRemote,LabelNhaSanXuatRemote,LabelCongSuatRemote,LabelNgayHetHanRemote,LabelNhaCungCapRemote,LabelNgaySanXuatRemote,LabelThoiGianBaoHanhRemote,LabelSoLuongRemote;
    public JLabel getLabelSoLuongRemote() {
        return LabelSoLuongRemote;
    }
    private JTextField txtMaHangRemote, txtTenHangRemote, txtSoLuongTonRemote,txtDonGiaRemote,txtNhaSanXuatRemote,txtNgayNhapKhoRemote,txtNgaySanXuatRemote,txtNgayHetHanRemote,txtNhaCungCapRemote,txtThoiGianBaoHanhThangRemote,txtCongSuatRemote,txtSoLuongRemote;
   
    public void setTxtMaHangRemote(JTextField txtMaHangRemote) {
        this.txtMaHangRemote = txtMaHangRemote;
    }
    public void setTxtTenHangRemote(JTextField txtTenHangRemote) {
        this.txtTenHangRemote = txtTenHangRemote;
    }
    public void setTxtSoLuongTonRemote(JTextField txtSoLuongTonRemote) {
        this.txtSoLuongTonRemote = txtSoLuongTonRemote;
    }
    public void setTxtDonGiaRemote(JTextField txtDonGiaRemote) {
        this.txtDonGiaRemote = txtDonGiaRemote;
    }
    public void setTxtNhaSanXuatRemote(JTextField txtNhaSanXuatRemote) {
        this.txtNhaSanXuatRemote = txtNhaSanXuatRemote;
    }
    public void setTxtNgayNhapKhoRemote(JTextField txtNgayNhapKhoRemote) {
        this.txtNgayNhapKhoRemote = txtNgayNhapKhoRemote;
    }
    public void setTxtNgaySanXuatRemote(JTextField txtNgaySanXuatRemote) {
        this.txtNgaySanXuatRemote = txtNgaySanXuatRemote;
    }
    public void setTxtNgayHetHanRemote(JTextField txtNgayHetHanRemote) {
        this.txtNgayHetHanRemote = txtNgayHetHanRemote;
    }
    public void setTxtNhaCungCapRemote(JTextField txtNhaCungCapRemote) {
        this.txtNhaCungCapRemote = txtNhaCungCapRemote;
    }
    public void setTxtThoiGianBaoHanhThangRemote(JTextField txtThoiGianBaoHanhThangRemote) {
        this.txtThoiGianBaoHanhThangRemote = txtThoiGianBaoHanhThangRemote;
    }
    public void setTxtCongSuatRemote(JTextField txtCongSuatRemote) {
        this.txtCongSuatRemote = txtCongSuatRemote;
    }
    public void setTxtSoLuongRemote(JTextField txtSoLuongRemote) {
        this.txtSoLuongRemote = txtSoLuongRemote;
    }
    public JTextField getTxtSoLuongRemote() {
        return txtSoLuongRemote;
    }
    JTable tableRemote;
    public JTable getTableRemote() {
        return tableRemote;
    }
    private JButton btnXoaRemote,btnThemRemote, btnSuaRemote,btnTimKiemRemote,btnTongSoLuongRemote;
    
    private JMenuBar menuBarRemote;
    private JMenu MenuRemote;
    private JMenuItem MenuItemHangThucPhamRemote,MenuItemHangDienMayRemote,MenuItemHangSanhSuRemote ;
    private DefaultTableModel tableModelRemote;
    private JScrollPane scrollPane;
 private HangHoaController hangHoaController;
    public QuanLiHangHoaUI(ChucNang chucNang) {
        this.chucNang = chucNang;
       
        
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setBounds(100, 100, 1127, 875);
        getContentPane().setLayout(null);

         menuBarRemote = new JMenuBar();
        setJMenuBar(menuBarRemote);

         MenuRemote = new JMenu("Phân loại");
        MenuRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        menuBarRemote.add(MenuRemote);

         MenuItemHangThucPhamRemote = new JMenuItem("Hàng thực phẩm");
        MenuItemHangThucPhamRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        MenuRemote.add(MenuItemHangThucPhamRemote);

         MenuItemHangDienMayRemote = new JMenuItem("Hàng điện máy");
        MenuItemHangDienMayRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        MenuRemote.add(MenuItemHangDienMayRemote);

         MenuItemHangSanhSuRemote = new JMenuItem("Hàng sành sứ");
        MenuItemHangSanhSuRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        MenuRemote.add(MenuItemHangSanhSuRemote);

         panelChungRemote = new JPanel();
        panelChungRemote.setBounds(235, 24, 563, 160);
        getContentPane().add(panelChungRemote);
        panelChungRemote.setLayout(null);

         LabelMaHangRemote = new JLabel("Mã hàng:");
        LabelMaHangRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelMaHangRemote.setBounds(77, 10, 114, 21);
        panelChungRemote.add(LabelMaHangRemote);

         LabelTenHangRemote = new JLabel("Tên hàng:");
        LabelTenHangRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelTenHangRemote.setBounds(77, 41, 77, 21);
        panelChungRemote.add(LabelTenHangRemote);

        LabelSoLuongTonRemote = new JLabel("Số lượng tồn:");
        LabelSoLuongTonRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelSoLuongTonRemote.setBounds(77, 75, 99, 21);
        panelChungRemote.add(LabelSoLuongTonRemote);

        LabelDonGiaRemote = new JLabel("Đơn giá:");
        LabelDonGiaRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelDonGiaRemote.setBounds(77, 106, 65, 21);
        panelChungRemote.add(LabelDonGiaRemote);

        LabelSoLuongRemote = new JLabel("Số Lượng:");
        LabelSoLuongRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelSoLuongRemote.setBounds(77, 133, 70, 21);
        panelChungRemote.add(LabelSoLuongRemote);

        txtMaHangRemote = new JTextField();
        txtMaHangRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtMaHangRemote.setBounds(217, 10, 254, 19);
        panelChungRemote.add(txtMaHangRemote);
        txtMaHangRemote.setColumns(10);

        txtTenHangRemote = new JTextField();
        txtTenHangRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtTenHangRemote.setColumns(10);
        txtTenHangRemote.setBounds(217, 45, 254, 19);
        panelChungRemote.add(txtTenHangRemote);

        txtSoLuongTonRemote = new JTextField();
        txtSoLuongTonRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtSoLuongTonRemote.setColumns(10);
        txtSoLuongTonRemote.setBounds(217, 79, 254, 19);
        panelChungRemote.add(txtSoLuongTonRemote);

        txtDonGiaRemote = new JTextField();
        txtDonGiaRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtDonGiaRemote.setColumns(10);
        txtDonGiaRemote.setBounds(217, 110, 254, 19);
        panelChungRemote.add(txtDonGiaRemote);

        txtSoLuongRemote = new JTextField();
        txtSoLuongRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtSoLuongRemote.setColumns(10);
        txtSoLuongRemote.setBounds(217, 138, 254, 19);
        panelChungRemote.add(txtSoLuongRemote);

         panelHangSanhSuRemote = new JPanel();
        panelHangSanhSuRemote.setBounds(235, 180, 563, 70);
        getContentPane().add(panelHangSanhSuRemote);
        panelHangSanhSuRemote.setLayout(null);

        txtNhaSanXuatRemote = new JTextField();
        txtNhaSanXuatRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtNhaSanXuatRemote.setColumns(10);
        txtNhaSanXuatRemote.setBounds(194, 10, 277, 19);
        panelHangSanhSuRemote.add(txtNhaSanXuatRemote);

         LabelNgayNhapKhoRemote = new JLabel("Ngày nhập kho:");
        LabelNgayNhapKhoRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelNgayNhapKhoRemote.setBounds(78, 42, 106, 19);
        panelHangSanhSuRemote.add(LabelNgayNhapKhoRemote);

         LabelNhaSanXuatRemote = new JLabel("Nhà Cung Cấp:");
        LabelNhaSanXuatRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelNhaSanXuatRemote.setBounds(78, 11, 106, 21);
        panelHangSanhSuRemote.add(LabelNhaSanXuatRemote);

        txtNgayNhapKhoRemote = new JTextField();
        txtNgayNhapKhoRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtNgayNhapKhoRemote.setColumns(10);
        txtNgayNhapKhoRemote.setBounds(194, 42, 277, 19);
        panelHangSanhSuRemote.add(txtNgayNhapKhoRemote);

        // Initialize table model
        String[] columnNames = {
            "Mã hàng", "Tên hàng", "Số lượng tồn", "Đơn giá", 
            "Ngày sản xuất", "Ngày hết hạn", "Nhà cung cấp", 
            "Thời gian bảo hành", "Công suất", "Nhà sản xuất", "Ngày nhập kho","Thuế VAT"
        };

        tableModelRemote = new DefaultTableModel(columnNames, 0);
        tableRemote = new JTable(tableModelRemote);
        tableRemote.setAutoResizeMode(JTable.AUTO_RESIZE_ALL_COLUMNS);

         scrollPane = new JScrollPane(tableRemote);
        scrollPane.setBounds(10, 480, 1093, 231);
        getContentPane().add(scrollPane);

         btnThemRemote = new JButton("Thêm");
        btnThemRemote.setBounds(226, 422, 85, 38);
        btnThemRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        getContentPane().add(btnThemRemote);

        btnXoaRemote = new JButton("Xóa");
        btnXoaRemote.setBounds(417, 422, 85, 38);
        btnXoaRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        getContentPane().add(btnXoaRemote);

         btnSuaRemote = new JButton("Sửa");
        btnSuaRemote.setBounds(321, 422, 85, 38);
        btnSuaRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        getContentPane().add(btnSuaRemote);

         btnTimKiemRemote = new JButton("Tìm kiếm");
        btnTimKiemRemote.setBounds(512, 422, 99, 38);
        btnTimKiemRemote.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                // Implement search action
            }
        });
        btnTimKiemRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        getContentPane().add(btnTimKiemRemote);

         btnTongSoLuongRemote = new JButton("Tính tổng số lượng");
        btnTongSoLuongRemote.setBounds(620, 422, 165, 38);
        btnTongSoLuongRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        getContentPane().add(btnTongSoLuongRemote);


         panelHangThucPhamRemote = new JPanel();
        panelHangThucPhamRemote.setBounds(235, 180, 563, 105);
        getContentPane().add(panelHangThucPhamRemote);
        panelHangThucPhamRemote.setLayout(null);

        txtNgaySanXuatRemote = new JTextField();
        txtNgaySanXuatRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtNgaySanXuatRemote.setColumns(10);
        txtNgaySanXuatRemote.setBounds(218, 10, 253, 19);
        panelHangThucPhamRemote.add(txtNgaySanXuatRemote);

         LabelNgayHetHanRemote = new JLabel("Ngày hết hạn:");
        LabelNgayHetHanRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelNgayHetHanRemote.setBounds(78, 42, 97, 19);
        panelHangThucPhamRemote.add(LabelNgayHetHanRemote);

         LabelNhaCungCapRemote = new JLabel("Nhà cung cấp:");
        LabelNhaCungCapRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelNhaCungCapRemote.setBounds(78, 71, 97, 21);
        panelHangThucPhamRemote.add(LabelNhaCungCapRemote);

         LabelNgaySanXuatRemote = new JLabel("Ngày sản xuất:");
        LabelNgaySanXuatRemote.setBounds(78, 11, 107, 21);
        panelHangThucPhamRemote.add(LabelNgaySanXuatRemote);
        LabelNgaySanXuatRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));

        txtNgayHetHanRemote = new JTextField();
        txtNgayHetHanRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtNgayHetHanRemote.setColumns(10);
        txtNgayHetHanRemote.setBounds(218, 42, 253, 19);
        panelHangThucPhamRemote.add(txtNgayHetHanRemote);

        txtNhaCungCapRemote = new JTextField();
        txtNhaCungCapRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtNhaCungCapRemote.setColumns(10);
        txtNhaCungCapRemote.setBounds(218, 75, 253, 19);
        panelHangThucPhamRemote.add(txtNhaCungCapRemote);

        panelHangDienMayRemote = new JPanel();
        panelHangDienMayRemote.setBounds(234, 180, 508, 100);
        getContentPane().add(panelHangDienMayRemote);
        panelHangDienMayRemote.setLayout(null);

        txtThoiGianBaoHanhThangRemote = new JTextField();
        txtThoiGianBaoHanhThangRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtThoiGianBaoHanhThangRemote.setColumns(10);
        txtThoiGianBaoHanhThangRemote.setBounds(300, 10, 171, 19);
        panelHangDienMayRemote.add(txtThoiGianBaoHanhThangRemote);

         LabelCongSuatRemote = new JLabel("Công suất (kW):");
        LabelCongSuatRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        LabelCongSuatRemote.setBounds(78, 42, 133, 19);
        panelHangDienMayRemote.add(LabelCongSuatRemote);

         LabelThoiGianBaoHanhRemote = new JLabel("Thời gian bảo hành (tháng):");
         LabelThoiGianBaoHanhRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
         LabelThoiGianBaoHanhRemote.setBounds(78, 11, 187, 21);
        panelHangDienMayRemote.add(LabelThoiGianBaoHanhRemote);

        txtCongSuatRemote = new JTextField();
        txtCongSuatRemote.setFont(new Font("Segoe UI", Font.PLAIN, 15));
        txtCongSuatRemote.setColumns(10);
        txtCongSuatRemote.setBounds(300, 42, 171, 19);
        panelHangDienMayRemote.add(txtCongSuatRemote);

panelHangDienMayRemote.setVisible(false);
panelHangSanhSuRemote.setVisible(false);
panelHangThucPhamRemote.setVisible(false);

         setVisible(true);
    }
public void setHangHoaController(HangHoaController hangHoaController) {
    this.hangHoaController = hangHoaController;
    initializeActions();  // Gọi để thiết lập các hành động
}
    private void initializeActions() {
        // Create ActionListener for menu items
        MenuItemHangThucPhamRemote.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                hangHoaController.showHangThucPhamPanel();
            }
        });

        MenuItemHangDienMayRemote.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                hangHoaController.showHangDienMayPanel();
            }

        });

        MenuItemHangSanhSuRemote.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                hangHoaController.showHangSanhSuPanel();
            }
        });

        
    }


    
    //GetMenuPanel
    public JPanel getPanelChungRemote() {
        return panelChungRemote;
    }
    public JPanel getPanelHangThucPhamRemote() {
        return panelHangThucPhamRemote;
    }
    public JPanel getPanelHangDienMayRemote() {
        return panelHangDienMayRemote;
    }

    //GetMenuItem
    public JMenuItem getMenuItemHangThucPhamRemote() {
        return MenuItemHangThucPhamRemote;
    }
    public JMenuItem getMenuItemHangDienMayRemote() {
        return MenuItemHangDienMayRemote;
    }
    public JMenuItem getMenuItemHangSanhSuRemote() {
        return MenuItemHangSanhSuRemote;
    }
    public JPanel getPanelHangSanhSuRemote() {
        return panelHangSanhSuRemote;
    }

//get button
    public JButton getBtnXoaRemote() {
        return btnXoaRemote;
    }
    public JButton getBtnThemRemote() {
        return btnThemRemote;
    }
    public JButton getBtnSuaRemote() {
        return btnSuaRemote;
    }
    public JButton getBtnTimKiemRemote() {
        return btnTimKiemRemote;
    }
    public JButton getBtnTongSoLuongRemote() {
        return btnTongSoLuongRemote;
    }

    //Get text
     public JTextField getTxtMaHangRemote() {
        return txtMaHangRemote;
    }
    public JTextField getTxtTenHangRemote() {
        return txtTenHangRemote;
    }
    public JTextField getTxtSoLuongTonRemote() {
        return txtSoLuongTonRemote;
    }
    public JTextField getTxtDonGiaRemote() {
        return txtDonGiaRemote;
    }
    public JTextField getTxtNhaSanXuatRemote() {
        return txtNhaSanXuatRemote;
    }
    public JTextField getTxtNgayNhapKhoRemote() {
        return txtNgayNhapKhoRemote;
    }
    public JTextField getTxtNgaySanXuatRemote() {
        return txtNgaySanXuatRemote;
    }
    public JTextField getTxtNgayHetHanRemote() {
        return txtNgayHetHanRemote;
    }
    public JTextField getTxtNhaCungCapRemote() {
        return txtNhaCungCapRemote;
    }
    public JTextField getTxtThoiGianBaoHanhThangRemote() {
        return txtThoiGianBaoHanhThangRemote;
    }
    public JTextField getTxtCongSuatRemote() {
        return txtCongSuatRemote;
    }
    
    public String getFind() {
        String idStr = JOptionPane.showInputDialog(this, "Nhập mã hàng hóa cần tìm: ");
        return idStr;
    }
    
    public static void main(String[] args) throws ClassNotFoundException {
     HangHoaPersistenceService hangHoaPersistenceService = new HangHoaPersistenceServiceImpl();
    ChucNang chucNang = new ChucNangImpl(hangHoaPersistenceService);
    QuanLiHangHoaUI ui = new QuanLiHangHoaUI(chucNang);
    HangHoaController hangHoaController = new HangHoaController(ui, chucNang,hangHoaPersistenceService);
    ui.setHangHoaController(hangHoaController);
       
    }
}
