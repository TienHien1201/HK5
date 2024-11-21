using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_MotSoBai
{
    public partial class Bai3_2 : Form
    {
        public Bai3_2()
        {
            InitializeComponent();
        }
        public static int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int a = int.Parse(txt_a.Text);
                int b = int.Parse(txt_b.Text);
                Double USCNN = USCLN(a, b);
                txt_ketqua.Text = USCNN.ToString();
            }
            if (radioButton2.Checked == true)
            {
                int a = int.Parse(txt_a.Text);
                int b = int.Parse(txt_b.Text);
                Double BSCNN = Math.Abs(a * b) / USCLN(a, b);
                txt_ketqua.Text = BSCNN.ToString();

            }
            if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Chưa chọn Tìm !");
            }
            if (txt_a.Text == "" || txt_b.Text == "")
            {
                MessageBox.Show("A Hoặc B không được bỏ trống !");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
