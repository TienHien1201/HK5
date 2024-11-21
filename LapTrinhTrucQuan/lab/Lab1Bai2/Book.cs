namespace BaiTap2
{
    public class Book : IBook, IComparable<Book>
    {
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string SoHieuISBN { get; set; }
        public List<string> DanhMucChuongSach { get; set; }

        public Book(string title, string author, string publisher, int year, string isbn, List<string> chapters)
        {
            TenSach = title;
            TenTacGia = author;
            NhaXuatBan = publisher;
            NamXuatBan = year;
            SoHieuISBN = isbn;
            DanhMucChuongSach = chapters;
        }

        public void XuatSach()
        {
            Console.WriteLine($"Ten Sach: {TenSach}");
            Console.WriteLine($"Tac Gia: {TenTacGia}");
            Console.WriteLine($"Nha Xuat Ban: {NhaXuatBan}");
            Console.WriteLine($"Nam Xuat Ban: {NamXuatBan}");
            Console.WriteLine($"So Hieu ISBN: {SoHieuISBN}");
            Console.WriteLine("Danh muc chuong:");
            foreach (var chapter in DanhMucChuongSach)
            {
                Console.WriteLine($"- {chapter}");
            }
        }

        public int CompareTo(Book other)
        {
            return string.Compare(this.TenSach, other.TenSach, StringComparison.OrdinalIgnoreCase);
        }
    }
}