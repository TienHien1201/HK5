using Buoi5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buoi5.Bai7Lab4
{
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }
       Model1 Data = new Model1();    
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
 if (textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ít nhất các thông tin!");
                ;
            }
            else
            {
                KetQua ketQua = new KetQua();
                ketQua.MaSo = int.Parse(comboBox1.Text);
                ketQua.MaMH = comboBox3.Text;

                ketQua.Diem = int.Parse(textBox5.Text);
              
                Data.SaveChanges();
                MessageBox.Show("nhập điểm thành công");
            }
        }
    }
}