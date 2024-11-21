using System;

namespace LabOne
{
    internal class NhaQuanLi
    {
        private string HoTen;
        private int NamSinh;
        private string BangCap;
        private string ChucVu;
        private int SoNgayCongThang;
        private int BacLuong;

     
        public NhaQuanLi() { }

        public NhaQuanLi(string hoTen, int namSinh, string bangCap, string chucVu, int soNgayCongThang, int bacLuong)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
            ChucVu = chucVu;
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

    
        public int GetSoNgayCongThang() { return SoNgayCongThang; }
        public void SetSoNgayCongThang(int value) { SoNgayCongThang = value; }

        public int GetBacLuong() { return BacLuong; }
        public void SetBacLuong(int value) { BacLuong = value; }

      
        public void Nhap()
        {

            Console.Write("\nNhap Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("\nNhap Nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("\nNhap Bang cap: ");
            BangCap = Console.ReadLine();
            Console.Write("\nNhap Chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("\nNhap So ngay cong trong thang: ");
            SoNgayCongThang = int.Parse(Console.ReadLine());
            Console.Write("\nNhap Bac luong: ");
            BacLuong = int.Parse(Console.ReadLine());
        }

     
        public void Xuat()
        {
            Console.WriteLine($"Ho Ten: {HoTen}\nNam sinh: {NamSinh}\nBang cap: {BangCap}\nChuc vu: {ChucVu}\nSo ngay cong trong thang: {SoNgayCongThang}\nBac Luong: {BacLuong}");
        }
        public double luong()
        {
            return SoNgayCongThang * BacLuong;
        }
    }
}
