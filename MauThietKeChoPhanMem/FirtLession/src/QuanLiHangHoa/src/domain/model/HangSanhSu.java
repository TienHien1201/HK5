package QuanLiHangHoa.src.domain.model;

import java.util.Date;
import java.io.Serializable;

public class HangSanhSu extends HangHoa{
    
    private String nhacungcap;
    private Date ngaynhapkho;
    
    public HangSanhSu(String tenloaihang, String maloaihang, int soluong, Double dongia, int soLuongTonkho,
            Double thueVat, String nhacungcap, Date ngaynhapkho) {
        super(tenloaihang, maloaihang, soluong, dongia, soLuongTonkho, thueVat);
        this.nhacungcap = nhacungcap;
        this.ngaynhapkho = ngaynhapkho;
    }
    public String getNhacungcap() {
        return nhacungcap;
    }
    public void setNhacungcap(String nhacungcap) {
        this.nhacungcap = nhacungcap;
    }
    public Date getNgaynhapkho() {
        return ngaynhapkho;
    }
    public void setNgaynhapkho(Date ngaynhapkho) {
        this.ngaynhapkho = ngaynhapkho;
    }

}
