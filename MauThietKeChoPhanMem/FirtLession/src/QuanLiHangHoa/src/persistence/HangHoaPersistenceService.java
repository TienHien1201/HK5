package QuanLiHangHoa.src.persistence;

import java.util.List;

import QuanLiHangHoa.src.domain.model.HangDienMay;
import QuanLiHangHoa.src.domain.model.HangHoa;
import QuanLiHangHoa.src.domain.model.HangSanhSu;
import QuanLiHangHoa.src.domain.model.HangThucPham;

public interface HangHoaPersistenceService {
     void save(Object hang);
   void addHangThucPham(HangThucPham hangThucPham)throws ClassNotFoundException;
   void addHangDienMay(HangDienMay hangDienMay)throws ClassNotFoundException;
   void addHangSanhSu(HangSanhSu hangSanhSu)throws ClassNotFoundException;
    void delete(String maloaihang) throws ClassNotFoundException;
    void update(HangDienMay hangDienMay) throws ClassNotFoundException;
    void update(HangSanhSu hangSanhSu) throws ClassNotFoundException;
    void update(HangThucPham hangThucPham) throws ClassNotFoundException;
    HangDienMay findHangDienMayById(String id) throws ClassNotFoundException;
    HangSanhSu findHangSanhSuById(String id) throws ClassNotFoundException;
    HangThucPham findHangThucPhamById(String id) throws ClassNotFoundException;
    List<HangDienMay> getAllHangDienMay() throws ClassNotFoundException;
    List<HangSanhSu> getAllHangSanhSu() throws ClassNotFoundException;
    List<HangThucPham> getAllHangThucPham() throws ClassNotFoundException;
    Double TongSoLuong(String loaiHang) throws ClassNotFoundException;
    double tinhThue(HangHoa hangHoa);
}
