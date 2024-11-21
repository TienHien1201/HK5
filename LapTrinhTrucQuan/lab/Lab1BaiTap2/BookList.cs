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

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                book.DisplayInfo();
                Console.WriteLine();
            }
        }

        public void SortByAuthor()
        {
            books.Sort((x, y) => string.Compare(x.Author, y.Author, StringComparison.OrdinalIgnoreCase));
        }

        public void SortByTitle()
        {
            books.Sort();
        }

        public void SortByYear()
        {
            books.Sort((x, y) => x.Year.CompareTo(y.Year));
        }

        public void NhapDanhSach()
        {
            while (true)
            {
                Console.WriteLine("Nhap thong tin sach:");
                Console.Write("Ten sach: ");
                string title = Console.ReadLine();
                Console.Write("Ten tac gia: ");
                string author = Console.ReadLine();
                Console.Write("Nha xuat ban: ");
                string publisher = Console.ReadLine();
                Console.Write("Nam xuat ban: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("So hieu ISBN: ");
                string isbn = Console.ReadLine();
                List<string> chapters = new List<string>();
                Console.WriteLine("Nhap cac chuong (nhap 'x' de ket thuc):");
                while (true)
                {
                    string chapter = Console.ReadLine();
                    if (chapter.ToLower() == "x") break;
                    chapters.Add(chapter);
                }

                Book book = new Book(title, author, publisher, year, isbn, chapters);
                AddBook(book);

                Console.WriteLine("Tiep tuc nhap sach? (y/n): ");
                string continueInput = Console.ReadLine();
                if (continueInput.ToLower() == "n") break;
            }
        }

        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sach cac cuon sach:");
            DisplayBooks();
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
                //if (!int.TryParse(luachon, out chon))
                //{
                //    Console.WriteLine("Lua chon khong hop le.");
                //    continue;
                //}
               
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
                    SortByAuthor();
                    DisplayBooks();
                }
                else if (chon == 4)
                {
                    Console.WriteLine("Danh sach sach theo ten sach:");
                    SortByTitle();
                    DisplayBooks();
                }
                else if (chon == 5)
                {
                    Console.WriteLine("Danh sach sach theo nam xuat ban:");
                    SortByYear();
                    DisplayBooks();
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