using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_MotSoBai
{
    public partial class Bai4_1 : Form
    {
        public Bai4_1()
        {
            InitializeComponent();
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            if (tbTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }
            decimal TongTien = 0;
            if (cbCaoVoi.Checked) TongTien += 100000;
            if (cbTayTrang.Checked) TongTien += 1200000;
            if (cbChupHinh.Checked) TongTien += 200000;
            if (NumCai.Value > 0) TongTien += NumCai.Value * 80000;
            //định dạng phân cách phần ngàn bằng dấu . hoặc ,
            tbTongTien.Text = TongTien.ToString("N0");
            if (TongTien != 0)
                listBox1.Items.Add(tbTenKhachHang.Text + " - " + TongTien);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> contents = new List<string>();
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Chưa có gì để lưu!");
            }
            else
            {
                foreach (string item in listBox1.Items)
                    contents.Add(item);
                //lưu lên file
                System.IO.File.WriteAllLines(path, contents);
                MessageBox.Show("Đã lưu lên file: " + path);
            }
        }
        string path = Application.StartupPath + "\\File\\Bai4Cau1.txt";
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string[] contents = File.ReadAllLines(path);
                foreach (string item in contents)
                {
                    listBox1.Items.Add(item);
                }    
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu thanh toán!");
            }
        }
    }
}
