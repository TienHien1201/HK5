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
    public partial class Bai4_4 : Form
    {
        private ErrorProvider errSonguyen;
        public Bai4_4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctSoNguyen = (Control)sender;
            errSonguyen = new ErrorProvider();
            if (ctSoNguyen.Text.Length > 0)
                if (!char.IsDigit(ctSoNguyen.Text[ctSoNguyen.Text.Length - 1]))
                    this.errSonguyen.SetError(ctSoNguyen, "Vui lòng nhập số nguyên !");
                else
                    this.errSonguyen.Clear();
        }

        private void Bai4_4_Load(object sender, EventArgs e)
        {

        }

        private void Bai4_4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Add(txt_songuyen.Text);
            txt_songuyen.Text = "";
            txt_songuyen.Focus();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
         int n =  lstKetQua.Items.Count;
            for(int i = 0; i < n; i++ )
            {
                int tam = int.Parse(lstKetQua.Items[i].ToString()) + 2;
                lstKetQua.Items.RemoveAt(i);
                lstKetQua.Items.Insert(i, tam.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count; //Số mục trong 1st
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 0)
                {

                    string s = lstKetQua.Items[i].ToString(); //Lay gia tri muc gia tri chan
            lstKetQua.SelectedItem = s;//Chon muc co gia tri chan
            break; //Thuc hien duoc so chn dau thi ket thuc vong lap
           }
        }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count; //Số mục trong 1st
            for (int i = n - 1; i >= 0; i--)
            {
            
if (int.Parse(lstKetQua.Items[i].ToString()) % 2 == 1)
{
string s = lstKetQua.Items[i].ToString();//Lay gia tri muc gia tri lè
lstKetQua.SelectedItem = s;//Chon muc co gia tri le
break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap
        }
}
}

        private void button6_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.SelectedItems.Count; //Số mục dang duoc chon trong IstKetqua
            for (int i = n - 1; i >= 0; i--)
                lstKetQua.Items.Remove(lstKetQua.SelectedItems[i].ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Remove(lstKetQua.Items[0].ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = lstKetQua.Items.Count;
            lstKetQua.Items.Remove(lstKetQua.Items[n - 1].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}