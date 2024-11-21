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

        // Constructor không tham số
        public NhaQuanLi() { }

        // Constructor với tham số
        public NhaQuanLi(string hoTen, int namSinh, string bangCap, string chucVu, int soNgayCongThang, int bacLuong)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
            ChucVu = chucVu;
            SoNgayCongThang = soNgayCongThang;
            BacLuong = bacLuong;
        }

        // Phương thức get và set cho HoTen
        public string GetHoTen() { return HoTen; }
        public void SetHoTen(string value) { HoTen = value; }

        // Phương thức get và set cho NamSinh
        public int GetNamSinh() { return NamSinh; }
        public void SetNamSinh(int value) { NamSinh = value; }

        // Phương thức get và set cho BangCap
        public string GetBangCap() { return BangCap; }
        public void SetBangCap(string value) { BangCap = value; }

        // Phương thức get và set cho ChucVu
        public string GetChucVu() { return ChucVu; }
        public void SetChucVu(string value) { ChucVu = value; }

        // Phương thức get và set cho SoNgayCongThang
        public int GetSoNgayCongThang() { return SoNgayCongThang; }
        public void SetSoNgayCongThang(int value) { SoNgayCongThang = value; }

        // Phương thức get và set cho BacLuong
        public int GetBacLuong() { return BacLuong; }
        public void SetBacLuong(int value) { BacLuong = value; }

        // Phương thức inPut
        public void inPut()
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

        // Phương thức outPut
        public void outPut()
        {
            Console.WriteLine($"Ho Ten: {HoTen}\nNam sinh: {NamSinh}\nBang cap: {BangCap}\nChuc vu: {ChucVu}\nSo ngay cong trong thang: {SoNgayCongThang}\nBac Luong: {BacLuong}");
        }
        public double luong()
        {
            return SoNgayCongThang * BacLuong;
        }
    }
}
