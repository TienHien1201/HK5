using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class KhoaHoc
    {
        private string HoTen;
        private int NamSinh;
        private string BangCap;
        private string ChucVu;
        private string SoBaibaoCongBo;
        private int SoNgayCongThang ;
        private int BacLuong;

        public KhoaHoc() { }
        public KhoaHoc(string hoTen, int namSinh, string bangCap, string chucVu, string soBaibaoCongBo, int soNgayCongThang, int bacLuong)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        BangCap = bangCap;
        ChucVu = chucVu;
        SoBaibaoCongBo = soBaibaoCongBo;
        SoNgayCongThang = soNgayCongThang;
        BacLuong = bacLuong;
    }
      
        public string GetHoTen() { return HoTen; }
        public void SetHoTen(string value) { HoTen = value; }
        public int GetNamSinh() { return NamSinh; }
        public void SetNamSinh(int value) { NamSinh = value; }
        public string GetBangCap() { return BangCap; }
        public void SetBangCap(string value) { BangCap = value; }
        public string GetChucVu() { return ChucVu; }
        public void SetChucVu(string value) { ChucVu = value; }

        public string GetSoBaibaoCongBo() { return SoBaibaoCongBo; }
        public void SetSoBaibaoCongBo(string value) { SoBaibaoCongBo = value; }
        public int GetSoNgayCongThang() { return SoNgayCongThang; }
        public void SetSoNgayCongThang(int value) { SoNgayCongThang = value; }
        public int GetBacLuong() { return BacLuong; }
        public void SetBacLuong(int value) { BacLuong = value; }

    public void inPut()
        {
            Console.WriteLine("Nhap Ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap Nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Bang cap: ");
            BangCap = Console.ReadLine();
            Console.WriteLine("Nhap Chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.WriteLine("Nhap So bai bao cong bo: ");
            SoBaibaoCongBo = Console.ReadLine();
            Console.WriteLine("Nhap So ngay cong trong thang: ");
            SoNgayCongThang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap bac luong: ");
            BacLuong = int.Parse(Console.ReadLine());
        }
        public void outPut()
        {
            Console.WriteLine($"Ho Ten: {HoTen}\nNam sinh: {NamSinh}\nBang cap: {BangCap}\nChuc vu: {ChucVu}\nSo bai bao cong bo: {SoBaibaoCongBo}\nSo ngay cong trong thang: {SoNgayCongThang}\nBac Luong: {BacLuong}");
        }

        public double luong() {
            return SoNgayCongThang * BacLuong; 
        }
    }

   
}
