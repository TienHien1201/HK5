﻿using Buoi5.DBBT8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.Bai8Lab4
{
    internal class NhanVien
    {
        BT8DTHD.BT8DTHD db = new BT8DTHD.BT8DTHD(); 
        public void XoaNhanVien(string index_nv)
        {
            string sql = "Delete from NhanVien where MaNhanVien = " +
            index_nv;
            db.CapNhatDuLieu(sql);
        }
        //Thêm 1 nhân viên mới
        public void ThemNhanVien(string ten, string ngaysinh,
        string diachi, string dienthoai, string index_bc)
        {
            string sql = string.Format("Insert Into NhanVien Values(N'{0}', '{1}', N'{2}', '{3}',{ 4})",
ten, ngaysinh, diachi, dienthoai, index_bc);
            db.CapNhatDuLieu(sql);

        }
        //Cập nhật nhân viên
        public void CapNhatNhanVien(string index_nv, string hoten,
        string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            //Chuẩn bị câu lẹnh truy vấn

            string str = string.Format("Update NHANVIEN set HoTenNhanVien = N'{0}', NgaySinh = '{1}', diachi = N'{2}', dienthoai = '{3}', MaBangCap = { 4} where MaNhanVien = {5}", hoten, ngaysinh, diachi, dienthoai, index_bc, index_nv);
db.CapNhatDuLieu(str);
        


}
    }
}