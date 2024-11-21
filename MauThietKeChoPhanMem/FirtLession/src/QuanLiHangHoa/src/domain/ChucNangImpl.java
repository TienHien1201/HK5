package QuanLiHangHoa.src.domain;

import QuanLiHangHoa.src.domain.model.HangDienMay;
import QuanLiHangHoa.src.domain.model.HangSanhSu;
import QuanLiHangHoa.src.domain.model.HangThucPham;
import QuanLiHangHoa.src.persistence.HangHoaPersistenceService;

import java.util.List;
import java.util.ArrayList;

public class ChucNangImpl implements ChucNang {
    private final HangHoaPersistenceService hangHoaPersistenceService;
    private List<HangDienMay> hangDienMayList;
    private List<HangSanhSu> hangSanhSuList;
    private List<HangThucPham> hangThucPhamList;

    public ChucNangImpl(HangHoaPersistenceService hangHoaPersistenceService) throws ClassNotFoundException {
        this.hangHoaPersistenceService = hangHoaPersistenceService;
        this.hangDienMayList = hangHoaPersistenceService.getAllHangDienMay();
        this.hangSanhSuList = hangHoaPersistenceService.getAllHangSanhSu();
        this.hangThucPhamList = hangHoaPersistenceService.getAllHangThucPham();
    }

    @Override
    public void Them(Object hang) {
        hangHoaPersistenceService.save(hang);
        if (hang instanceof HangDienMay) {
            hangDienMayList.add((HangDienMay) hang);
        } else if (hang instanceof HangSanhSu) {
            hangSanhSuList.add((HangSanhSu) hang);
        } else if (hang instanceof HangThucPham) {
            hangThucPhamList.add((HangThucPham) hang);
        }
    }

    @Override
    public void Xoa(String maloaihang) throws ClassNotFoundException {
        hangHoaPersistenceService.delete(maloaihang);
        hangDienMayList.removeIf(hang -> hang.getMaloaihang().equals(maloaihang));
        hangSanhSuList.removeIf(hang -> hang.getMaloaihang().equals(maloaihang));
        hangThucPhamList.removeIf(hang -> hang.getMaloaihang().equals(maloaihang));
    }

    @Override
    public void Sua(HangSanhSu hangSanhSu) throws ClassNotFoundException {
        hangHoaPersistenceService.update(hangSanhSu);
        for (int i = 0; i < hangSanhSuList.size(); i++) {
            if (hangSanhSuList.get(i).getMaloaihang().equals(hangSanhSu.getMaloaihang())) {
                hangSanhSuList.set(i, hangSanhSu);
                break;
            }
        }
    }

    @Override
    public void Sua(HangThucPham hangThucPham) throws ClassNotFoundException {
        hangHoaPersistenceService.update(hangThucPham);
        for (int i = 0; i < hangThucPhamList.size(); i++) {
            if (hangThucPhamList.get(i).getMaloaihang().equals(hangThucPham.getMaloaihang())) {
                hangThucPhamList.set(i, hangThucPham);
                break;
            }
        }
    }

    @Override
    public void Sua(HangDienMay hangDienMay) throws ClassNotFoundException {
        hangHoaPersistenceService.update(hangDienMay);
        for (int i = 0; i < hangDienMayList.size(); i++) {
            if (hangDienMayList.get(i).getMaloaihang().equals(hangDienMay.getMaloaihang())) {
                hangDienMayList.set(i, hangDienMay);
                break;
            }
        }
    }

    @Override
    public HangSanhSu timKiemHangSanhSu(String id) throws ClassNotFoundException {
        return hangHoaPersistenceService.findHangSanhSuById(id);
    }

    @Override
    public HangThucPham timKiemHangThucPham(String id) throws ClassNotFoundException {
        return hangHoaPersistenceService.findHangThucPhamById(id);
    }

    @Override
    public HangDienMay timKiemHangDienMay(String id) throws ClassNotFoundException {
        return hangHoaPersistenceService.findHangDienMayById(id);
    }

    @Override
    public double ThueVAT() {
        return 0.1; // 10% VAT
    }

    @Override
    public List<HangSanhSu> getHangSanhSu() {
        return hangSanhSuList;
    }

    @Override
    public List<HangThucPham> getHangThucPham() {
        return hangThucPhamList;
    }

    @Override
    public List<HangDienMay> getHangDienMay() {
        return hangDienMayList;
    }

}
