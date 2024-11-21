package QuanLiHangHoa.src.domain.model;

import java.util.Date;

public abstract class HangHoa {
  private String tenloaihang; 
    private String maloaihang;
    private int soluong;
    private Double dongia;
    private int SoLuongTonkho;
    private Double thueVat;
    public HangHoa(String tenloaihang, String maloaihang, int soluong, Double dongia, int soLuongTonkho,
            Double thueVat) {
        this.tenloaihang = tenloaihang;
        this.maloaihang = maloaihang;
        this.soluong = soluong;
        this.dongia = dongia;
        SoLuongTonkho = soLuongTonkho;
        this.thueVat = thueVat;
    }
    public String getTenloaihang() {
        return tenloaihang;
    }
    public void setTenloaihang(String tenloaihang) {
        this.tenloaihang = tenloaihang;
    }
    public String getMaloaihang() {
        return maloaihang;
    }
    public void setMaloaihang(String maloaihang) {
        this.maloaihang = maloaihang;
    }
    public int getSoluong() {
        return soluong;
    }
    public void setSoluong(int soluong) {
        this.soluong = soluong;
    }
    public Double getDongia() {
        return dongia;
    }
    public void setDongia(Double dongia) {
        this.dongia = dongia;
    }
    public int getSoLuongTonkho() {
        return SoLuongTonkho;
    }
    public void setSoLuongTonkho(int soLuongTonkho) {
        SoLuongTonkho = soLuongTonkho;
    }
    public Double getThueVat() {
        return thueVat;
    }
    public void setThueVat(Double thueVat) {
        this.thueVat = thueVat;
    }
    

    // Abstract method to be implemented by subclasses
    //public abstract String getCategory();
}
