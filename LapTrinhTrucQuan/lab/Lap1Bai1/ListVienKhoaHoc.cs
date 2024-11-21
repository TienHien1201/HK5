using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class ListVienKhoaHoc
    {
        ArrayList lists = new ArrayList();

        public void DanhSachChon()
        {
            while (true)
            {

               
                Console.WriteLine("\t\t\nMoi chon chuong trinh");
                Console.WriteLine("\n1.Nhap thong tin: nhan phim 1");
                Console.WriteLine("\n2.Xuat thong tin: nhan phim 2");
                Console.WriteLine("\n3.Tong luong cua tung nhan vien: phim 3 ");
                Console.WriteLine("\n4.Dung chuong trinh: phim 0");
                Console.WriteLine("\n-------------------------------------");
                string luachon = Console.ReadLine();
                int chon = int.Parse(luachon);
                if (chon == 1)
                {
                    while(true)
                    {
                  
                     Console.WriteLine("\t\t\nMENU Nhap");
                    Console.WriteLine("\n1.Nhap thong tin khoa Hoc: nhan phim 1");
                    Console.WriteLine("\n2.Nhap thong tin Nha Quan Li: nhan phim 2");
                    Console.WriteLine("\n3.Nhap thong tin Nhan Vien Phong Thi Nghiem: phim 3 ");
                    Console.WriteLine("\n4.Ngung nhap: phim 0");
                    Console.WriteLine("\n----------------------------------------------------");

                    string luachonNhap = Console.ReadLine();
                    int chonNhap = int.Parse(luachonNhap);

                    if (chonNhap == 1)
                    {
                        KhoaHoc khoa = new KhoaHoc();
                        khoa.Nhap();
                        lists.Add(khoa);
                    }
                    if (chonNhap == 2)
                    {
                        NhaQuanLi nql = new NhaQuanLi();
                        nql.Nhap();
                        lists.Add(nql);
                    }
                    if (chonNhap == 3)
                    {
                        NhanVienPhongThiNghiem nvptn = new NhanVienPhongThiNghiem();
                        nvptn.Nhap();
                        lists.Add(nvptn);
                    }
                    if (chonNhap == 0) break;
                }
                }

                if (chon == 2) {
                    Console.WriteLine("\t\t\n--------------------------------------------");
                    Console.WriteLine("\t\t\nDanh Sach Nhan Vien Phong thi nghiem\n");
                    if (lists.Count == 0)
                    {
                        Console.WriteLine("Khong ton tai thong tin !\n");
                            Console.WriteLine("--------------------------");
                    }
                    foreach (var obj in lists)
                    {
                        if (obj is KhoaHoc)
                        {
                            KhoaHoc khoaHoc = (KhoaHoc)obj;
                            Console.WriteLine("\nThong tin cua Khoa Hoc:");
                            khoaHoc.Xuat();
                        }
                        else if (obj is NhaQuanLi)
                        {
                            NhaQuanLi nhaQuanLi = (NhaQuanLi)obj;
                            Console.WriteLine("\nThong tin cua Nha Quan Li: ");
                            nhaQuanLi.Xuat(); 
                        }
                        else if (obj is NhanVienPhongThiNghiem)
                        {
                            NhanVienPhongThiNghiem nvptn = (NhanVienPhongThiNghiem)obj;
                            Console.WriteLine("\nThong tin cua Nhan Vien phong thi nghiem:");
                            nvptn.Xuat(); 
                        }
                    }
                }
                if (chon == 3) {
                    Console.WriteLine("\n------------------------------");
                    foreach (var obj in lists)
                    {
                        if (obj is KhoaHoc)
                        {
                            KhoaHoc khoaHoc = (KhoaHoc)obj;
                            Console.WriteLine("Luong cua khoa hoc: " + khoaHoc.luong());
                        }
                        if (obj is NhaQuanLi)
                        {
                            NhaQuanLi nql = (NhaQuanLi)obj;
                            Console.WriteLine("Luong cua Nha quan li: " + nql.luong());
                        }
                        if (obj is NhanVienPhongThiNghiem)
                        {
                            NhanVienPhongThiNghiem nvptn = (NhanVienPhongThiNghiem)obj;
                            Console.WriteLine("Luong cua Nhan vien phong thi nhiem: " + nvptn.GetLuongTrongThang);
                        }

                    }
                }
                if (chon == 0) break;
                else Console.WriteLine("\nLua chon khong hop le ! moi chon tu 0 - 4.\n");
            }
            }
        }
    }

