using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class BookList
    {
        private List<Book> books;

        public BookList()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void XuatAllSach()
        {
            foreach (var book in books)
            {
                book.XuatSach();
                Console.WriteLine();
            }
        }

        public void SapXepTheoTen()
        {
            books.Sort((x, y) => string.Compare(x.TenTacGia, y.TenTacGia, StringComparison.OrdinalIgnoreCase));
        }

        public void SapXepTheoTenSach()
        {
            books.Sort();
        }

        public void SapXepTheoNam()
        {
            books.Sort((x, y) => x.NamXuatBan.CompareTo(y.NamXuatBan));
        }

        public void NhapDanhSach()
        {
            while (true)
            {
                Console.WriteLine("Nhap thong tin sach:");
                Console.Write("Ten sach: ");
                string tenSach = Console.ReadLine();
                Console.Write("Ten tac gia: ");
                string tacGia = Console.ReadLine();
                Console.Write("Nha xuat ban: ");
                string nhaXuatBan = Console.ReadLine();
                Console.Write("Nam xuat ban: ");
                int namXuatBan = int.Parse(Console.ReadLine());
                Console.Write("So hieu ISBN: ");
                string soHieu = Console.ReadLine();
                List<string> danhMucChuong = new List<string>();
                Console.WriteLine("Nhap cac chuong (nhap 'x' de ket thuc):");
                while (true)
                {
                    string chuong = Console.ReadLine();
                    if (chuong.ToLower() == "x") break;
                    danhMucChuong.Add(chuong);
                }

                Book book = new Book(tenSach, tacGia, nhaXuatBan, namXuatBan, soHieu, danhMucChuong);
                AddBook(book);

                Console.WriteLine("Tiep tuc nhap sach? (y/n): ");
                string continueInput = Console.ReadLine();
                if (continueInput.ToLower() == "n") break;
            }
        }

        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sach cac cuon sach:");
            XuatAllSach();
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nMENU chuong trinh");
                Console.WriteLine("1. Nhap thong tin sach");
                Console.WriteLine("2. Xuat thong tin sach");
                Console.WriteLine("3. Xuat thong tin sach theo ten tac gia");
                Console.WriteLine("4. Xuat thong tin sach theo ten sach");
                Console.WriteLine("5. Xuat thong tin sach theo nam xuat ban");
                Console.WriteLine("0. Dung chuong trinh");
                Console.WriteLine("-------------------------------------");
                Console.Write("Nhap lua chon: ");
                string luachon = Console.ReadLine();
                int chon = int.Parse(luachon);
         
                if (chon == 1)
                {
                    NhapDanhSach();
                }
                else if (chon == 2)
                {
                    XuatDanhSach();
                }
                else if (chon == 3)
                {
                    Console.WriteLine("Danh sach sach theo ten tac gia:");
                    SapXepTheoTen();
                    XuatAllSach();
                }
                else if (chon == 4)
                {
                    Console.WriteLine("Danh sach sach theo ten sach:");
                    SapXepTheoTenSach();
                    XuatAllSach();
                }
                else if (chon == 5)
                {
                    Console.WriteLine("Danh sach sach theo nam xuat ban:");
                    SapXepTheoNam();
                    XuatAllSach();
                }
                else if (chon == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le.");
                }
            }
        }
    }
}