using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public interface IBook
    {
        string TenSach { get; set; }
        string TenTacGia { get; set; }
        string NhaXuatBan { get; set; }
        int NamXuatBan { get; set; }
        string SoHieuISBN { get; set; }
        List<string> DanhMucChuongSach { get; set; }

        void XuatSach();
    }
}