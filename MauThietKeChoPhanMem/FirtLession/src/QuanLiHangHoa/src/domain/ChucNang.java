package QuanLiHangHoa.src.domain;
import java.util.List;

import QuanLiHangHoa.src.domain.model.HangDienMay;
import QuanLiHangHoa.src.domain.model.HangSanhSu;
import QuanLiHangHoa.src.domain.model.HangThucPham;

public interface ChucNang {
    public void Them(Object hang) ;
    public void Xoa(String maloaihang) throws ClassNotFoundException ;

    public void Sua(HangSanhSu hangSanhSu) throws ClassNotFoundException ;
    public void Sua(HangThucPham hangThucPham) throws ClassNotFoundException ;
    public void Sua(HangDienMay hangDienMay) throws ClassNotFoundException ;
    
    HangSanhSu timKiemHangSanhSu(String id) throws ClassNotFoundException ;
    HangThucPham timKiemHangThucPham(String id) throws ClassNotFoundException ;
    HangDienMay timKiemHangDienMay(String id) throws ClassNotFoundException ;

    public double ThueVAT();

    List<HangSanhSu> getHangSanhSu();
    List<HangThucPham> getHangThucPham();
    List<HangDienMay> getHangDienMay();


}
