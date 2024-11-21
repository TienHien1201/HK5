using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ABC {
    internal class Student
    {
        private int MaSV;
        private string HoTen;
        private string Khoa;
        private double DiemTB;

        public int GetMaSV() { return MaSV; }

        public int MASV
        {
            get
            {
                return MaSV;
            }
        }
        public Student()
        {
            this.MaSV = 0;
            this.HoTen = "Chưa có tên";
            this.Khoa = "Chưa có khoa";
            this.DiemTB = 0;
        }
        public Student(Student student)
        {
            this.MaSV = student.MaSV;
            this.HoTen = student.HoTen;
            this.Khoa = student.Khoa;
            this.DiemTB = student.DiemTB;
        }
        public Student(int maSV, string hoTen, string khoa, float diemTB)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.Khoa = khoa;
            this.DiemTB = diemTB;
        }
        public void NhapThongTin()
        {
            Console.Write("+ Ma so: ");
            MaSV = Convert.ToInt32(Console.ReadLine());
            Console.Write("+ Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("+ Khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("+ Diem TB: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            /*Console.WriteLine("Ma so: " + MaSV);
            Console.WriteLine("Ho ten: {0}",HoTen);
            Console.WriteLine($"Khoa: {Khoa}");
            Console.WriteLine($"Diem TB: {DiemTB}");*/

            Console.WriteLine($"Ma so: {MaSV}\nHo ten: {HoTen}\nKhoa: {Khoa}\nDiemTB: {DiemTB}");

        }
    }

}

 