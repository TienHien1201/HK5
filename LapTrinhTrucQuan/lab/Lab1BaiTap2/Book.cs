using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    public class Book : IBook, IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public List<string> Chapters { get; set; }

        public Book(string title, string author, string publisher, int year, string isbn, List<string> chapters)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            ISBN = isbn;
            Chapters = chapters;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("Chapters:");
            foreach (var chapter in Chapters)
            {
                Console.WriteLine($"- {chapter}");
            }
        }

        public int CompareTo(Book other)
        {
            return string.Compare(this.Title, other.Title, StringComparison.OrdinalIgnoreCase);
        }
    }
}