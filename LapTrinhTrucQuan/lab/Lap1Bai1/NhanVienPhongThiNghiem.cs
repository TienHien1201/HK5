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

        public NhanVienPhongThiNghiem() { }

  
        public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, double luongTrongThang)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.bangCap = bangCap;
            this.luongTrongThang = luongTrongThang;
        }

        public string GetHoTen() { return hoTen; }
        public void SetHoTen(string value) { hoTen = value; }

        public int GetNamSinh() { return namSinh; }
        public void SetNamSinh(int value) { namSinh = value; }

        public string GetBangCap() { return bangCap; }
        public void SetBangCap(string value) { bangCap = value; }

        public double GetLuongTrongThang() { return luongTrongThang; }
        public void SetLuongTrongThang(double value) { luongTrongThang = value; }

        public void Nhap()
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

        public void Xuat()
        {
            Console.WriteLine($"Ho Ten: {hoTen}\nNam sinh: {namSinh}\nBang cap: {bangCap}\nLuong trong thang: {luongTrongThang}");
        }
    }
}

