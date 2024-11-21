using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buoi2Demo
{
    public partial class Lab2Bai5 : Form
    {
        public Lab2Bai5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_tendangnhap.Text) || !string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công !!!");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';

        }

        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienthi.Checked == true)
            {
                txt_matkhau.PasswordChar = (char)0;
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Lab2Bai5_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(txt_tendangnhap, "Chỉ được nhập ký tự a-z và 0-9");
            toolTip1.SetToolTip(txt_matkhau, "Chỉ được nhập ký tự từ 0-9");
            helpProvider1.HelpNamespace = "https://plpsoft.vn/30236-Bai-tap-C-Bai-5-Su-dung-ToolTip-HelpProvider-ErrorProvider-trong-C-windows-Form";


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F1)

                helpProvider1.HelpNamespace = "https://plpsoft.vn/30236-Bai-tap-C-Bai-5-Su-dung-ToolTip-HelpProvider-ErrorProvider-trong-C-windows-Form";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
