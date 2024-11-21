using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2Demo
{
    public partial class Lab2Cau2 : Form
    {
        public Lab2Cau2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tinhToan('*');
        }

        void tinhToan(char pheptoan)
        {


            double a = 0;
            try
            {
                a = Convert.ToDouble(textSo1.Text);
            }
            catch
            {
                MessageBox.Show("Số thứ nhất phải là số !");
                textSo1.Text = "";//nhập sai thì cho ô đó thành rỗng và
                textSo1.Focus();//con trỏ chuột nằm lại ô đó
                return;
            }
            double b = 0;
            try
            {
                b = Convert.ToDouble(textSo2.Text);
            }
            catch
            {
                MessageBox.Show("Số thứ hai phải là số !");
                textSo2.Text = "";//nhập sai thì cho ô đó thành rỗng và
                textSo2.Focus();//con trỏ chuột nằm lại ô đó
                return;
            }
            switch (pheptoan)
            {
                case '+':
                    textKq.Text = (a + b) + ""; break;
                case '-':
                    textKq.Text = (a - b) + ""; break;
                case '/':
                    textKq.Text = (a / b) + ""; break;
                case '*':
                    textKq.Text = (a * b) + ""; break;

            }
        }



        //Nút +
        private void button1_Click(object sender, EventArgs e)
        {
            tinhToan('+');


        }

        private void textKq_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tinhToan('-');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tinhToan('/');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textSo1.Text = "";
            textSo2.Text = "";
        }

        private void textSo2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
