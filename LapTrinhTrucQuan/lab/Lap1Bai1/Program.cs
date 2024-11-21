using ABC;
using LabOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    private static void Main(string[] args)
    {
        /*Student student = new Student();
        student.NhapThongTin();
        student.XuatThongTin();*/
        //Student[] Arr;
        //int n;
        //Console.Write("Cho biet so luong sinh vien: "  );
        //n = int.Parse(Console.ReadLine());
        //Arr = new Student[n];
        //for( int i = 0; i < n; i++ )
        //{
        //    Arr[i] = new Student();
        //    Console.WriteLine($"\tNhap sinh vien thu {i + 1}:");
        //    Arr[i].NhapThongTin();
        //    Console.WriteLine("------------------------------");
        //}
        //Console.WriteLine("Danh sach sinh vien");
        //Console.WriteLine("------------------------------");
        //foreach (Student item in Arr)
        //{
        //    item.XuatThongTin();
        //    Console.WriteLine("------------------------------");
        //}

        //StudentList L = new StudentList();
        //L.NhapDanhSach();
        //L.XuatDanhSach();
        //int Key;
        //Console.Write("Nhap ma so can tim: ");
        //Key = int.Parse(Console.ReadLine());
        //Student s = L.TimSinhVienTheoMaSo(Key);
        //if (s == null)
        //    Console.WriteLine($"Khong tim thay sinh vien co ma so {Key}");
        //else
        //{
        //    Console.WriteLine("Sinh vien tim thay: ");
        //    s.XuatThongTin();
        //}

        ListVienKhoaHoc listVienKhoaHoc = new ListVienKhoaHoc();
        listVienKhoaHoc.DanhSachChon();
    }
}