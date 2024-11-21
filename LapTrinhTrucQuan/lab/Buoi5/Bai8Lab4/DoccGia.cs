using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.Bai8Lab4
{
    internal class DoccGia
    {
        BT8DTHD.BT8DTHD db = new BT8DTHD.BT8DTHD();
        public void XoaDocGia(string index_dg)
        {
            string sql = "Delete from DocGia where MaDocGia = " +
            index_dg;
            db.CapNhatDuLieu(sql);
        }
        //Thêm 1 nhân viên mới
        public void ThemDocGia(string hoten,
        string ngaysinh, string diachi, string email, string ngaylap, string ngayhet, double tien)
        {
            string sql = string.Format("Insert Into DocGia Values(N'{0}', '{1}', N'{2}', '{3}',{ 4}),{ 5}),{ 6})",
hoten, ngaysinh, diachi, email, ngaylap, ngayhet,tien);
            db.CapNhatDuLieu(sql);

        }
        //Cập nhật nhân viên
        public void CapNhatDocGia(string index_dg, string hoten,
        string ngaysinh, string diachi, string email, string ngaylap, string ngayhet, double tien)
        {
            //Chuẩn bị câu lẹnh truy vấn

            string str = string.Format("Update DOCGIA set HoTenDocGia = N'{0}', NgaySinh = '{1}', diachi = N'{2}', Email = '{3}', NgayLapThe = { 4}, NgayHetHan = { 5}, TienNo = { 6}   where MaDocGia = {7}", hoten, ngaysinh, diachi, email, ngayhet, ngaylap, tien);
            db.CapNhatDuLieu(str);


        }
    }
}
