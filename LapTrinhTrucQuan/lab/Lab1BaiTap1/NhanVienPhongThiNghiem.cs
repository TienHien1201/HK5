using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabOne
{
    internal class NhanVienPhongThiNghiem
    {
        private string hoTen;
        private int namSinh;
        private string bangCap;
        private double luongTrongThang;

        // Constructor không tham số
        public NhanVienPhongThiNghiem() { }

        // Constructor với tham số
        public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, double luongTrongThang)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.bangCap = bangCap;
            this.luongTrongThang = luongTrongThang;
        }

        // Phương thức get và set cho HoTen
        public string GetHoTen() { return hoTen; }
        public void SetHoTen(string value) { hoTen = value; }

        // Phương thức get và set cho NamSinh
        public int GetNamSinh() { return namSinh; }
        public void SetNamSinh(int value) { namSinh = value; }

        // Phương thức get và set cho BangCap
        public string GetBangCap() { return bangCap; }
        public void SetBangCap(string value) { bangCap = value; }

        // Phương thức get và set cho LuongTrongThang
        public double GetLuongTrongThang() { return luongTrongThang; }
        public void SetLuongTrongThang(double value) { luongTrongThang = value; }

        // Phương thức inPut
        public void inPut()
        {
             Console.Write("\nNhap Ho ten: ");
             hoTen = Console.ReadLine();
             Console.Write("\nNhap Nam sinh: ");
             namSinh = int.Parse(Console.ReadLine());
             Console.Write("\nNhap Bang cap: ");
             bangCap = Console.ReadLine();
             Console.Write("\nNhap Luong trong thang: ");
             luongTrongThang = double.Parse(Console.ReadLine());
        }

        // Phương thức outPut
        public void outPut()
        {
            Console.WriteLine($"Ho Ten: {hoTen}\nNam sinh: {namSinh}\nBang cap: {bangCap}\nLuong trong thang: {luongTrongThang}");
        }
    }
}

