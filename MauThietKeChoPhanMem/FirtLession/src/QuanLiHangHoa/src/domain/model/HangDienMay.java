package QuanLiHangHoa.src.domain.model;



public class HangDienMay extends HangHoa{
    private String thoigianbaohanh; 
    private String congsuat;
      
    
    public HangDienMay(String tenloaihang, String maloaihang,  String thoigianbaohanh,String congsuat ,int soluong, int soLuongTonkho, Double dongia,
            Double thueVat) {
        super(tenloaihang, maloaihang, soluong, dongia, soLuongTonkho, thueVat);
        this.thoigianbaohanh = thoigianbaohanh;
        this.congsuat = congsuat;   
    }
    public String getThoigianbaohanh() {
        return thoigianbaohanh;
    }
    public void setThoigianbaohanh(String thoigianbaohanh) {
        this.thoigianbaohanh = thoigianbaohanh;
    }
    public String getCongsuat() {
        return congsuat;
    }
    public void setCongsuat(String congsuat) {
        this.congsuat = congsuat;
    }
    
    

}
