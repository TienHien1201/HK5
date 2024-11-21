package QuanLiHangHoa.src.domain.model;

import java.util.Date;

public class HangThucPham extends HangHoa{
   
    
    public HangThucPham(String tenloaihang, String maloaihang, int soluong, Double dongia, int soLuongTonkho,
            Double thueVat, Date ngaysanxuat, Date ngayhethan, String nahcungcap) {
        super(tenloaihang, maloaihang, soluong, dongia, soLuongTonkho, thueVat);
        this.ngaysanxuat = ngaysanxuat;
        this.ngayhethan = ngayhethan;
        this.nahcungcap = nahcungcap;
    }
    private Date ngaysanxuat;
    private Date ngayhethan;
    private String nahcungcap;
    public Date getNgaysanxuat() {
        return ngaysanxuat;
    }
    public void setNgaysanxuat(Date ngaysanxuat) {
        this.ngaysanxuat = ngaysanxuat;
    }
    public Date getNgayhethan() {
        return ngayhethan;
    }
    public void setNgayhethan(Date ngayhethan) {
        this.ngayhethan = ngayhethan;
    }
    public String getNahcungcap() {
        return nahcungcap;
    }
    public void setNahcungcap(String nahcungcap) {
        this.nahcungcap = nahcungcap;
    }
   
    

}
