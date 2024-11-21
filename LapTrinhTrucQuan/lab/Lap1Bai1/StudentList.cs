using ABC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class StudentList
    {
        List<Student> students = new List<Student>();

        public void NhapDanhSach()
        {
            while (true)
            {
                Student student = new Student();
                Console.WriteLine("\tNhap sinh vien can them:");
                student.NhapThongTin();
                students.Add(student);

                Console.WriteLine("------------------------------");
                Console.WriteLine("Tiep tuc khong?y/n: ");
                string chon = Console.ReadLine();
                if (chon == "n") break;
            }
        }
        public void XuatDanhSach()
        {
            Console.WriteLine("Danh sach sinh vien");
            Console.WriteLine("------------------------------");
            foreach (Student item in students)
            {
                item.XuatThongTin();
                Console.WriteLine("------------------------------");
            }
        }
        public Student TimSinhVienTheoMaSo(int key)
        {
            //for (int i = 0; i < students.Count; i++)
            //    if (students[i].GetMaSV() == key)
            //        return students[i];

            foreach (Student item in students)
                if (item.MASV == key)
                    return item;

            return null;
        }

        /// <summary>
        /// Hàm này dùng để tìm sinh viên theo mã số, tìm thấy trả về đối tượng Student, ngược lại trả về null
        /// </summary>
        /// <param name="key">Mã số cần tìm</param>
        /// <returns></returns>
        public Student TimTheoMaSo(int key)
        {
            return students.Find(s => s.MASV == key);
        }
    }
}
